using System.Reflection;
using System.Text.Json.Serialization;

public class TsTypesGenerator : IDisposable
{
    public TsTypesGenerator(TextWriter writer) : this(writer, new())
    { }

    public TsTypesGenerator(TextWriter writer, Configuration config)
    {
        this.Writer = writer;
        this.Config = config;
    }

    private bool FinishBefore()
    {
        if (this.sthBefore)
        {
            this.Writer.WriteLine();
            if (this.Config.AutoFlush)
            {
                this.Writer.Flush();
            }
            this.sthBefore = false;
            return true;
        }
        return false;
    }

    private TsTypesGenerator Write(Action action)
    {
        action();
        return this;
    }

    private TsTypesGenerator WriteIndent()
    {
        this.Writer.Write(new string(' ', 4 * this.indentLevel));
        return this;
    }

    private TsTypesGenerator WriteSemi()
    {
        return this.WriteExpression(";");
    }

    private Action Separator(string separator)
    {
        var isFirst = true;
        return () =>
        {
            if (isFirst)
            {
                isFirst = false;
                return;
            }
            this.WriteExpression(separator);
        };
    }

    private TsTypesGenerator WriteExpression(string value)
    {
        this.Writer.Write(value);
        this.sthBefore = true;
        return this;
    }

    private TsTypesGenerator WriteStatement(string value, bool emptyLineBefore = false)
    {
        if (this.FinishBefore() && emptyLineBefore)
        {
            this.Writer.WriteLine();
        }
        return this.WriteIndent().WriteExpression(value);
    }

    private LambdaCallDisposable WriteBlock()
    {
        this.Writer.WriteLine(" {");
        this.indentLevel += 1;
        this.sthBefore = false;
        return new LambdaCallDisposable(() =>
        {
            this.indentLevel -= 1;
            this.WriteStatement("}");
        });
    }

    private readonly HashSet<Type> WarnedTypes = new();
    private TsTypesGenerator WriteTypeName(Type type)
    {
        if (this.Config.Aliases.TryGetValue(type, out var alias))
        {
            Verify.False(type.IsGenericType);
            return this.WriteExpression(alias.Name ?? type.Name);
        }

        var att = type.GetCustomAttribute<GenerateTsAttribute>(false);
        if (att == null && !type.IsGenericParameter && this.WarnedTypes.Add(type.IsGenericType ? type.GetGenericTypeDefinition() : type))
        {
            Console.WriteLine($"!! WARNING: Type '{type.FullName ?? $"{type.Name} ({type.Namespace})"}' occurs in generation, but does not have 'GenerateTs' attribute.");
        }

        var name = att?.Name ?? type.Name.RegexReplace(@"`\d+$", "");
        return this.WriteExpression(name);
    }

    private bool IsAny(Type type)
    {
        return type == typeof(object) || AnyTypes.Any(t => type.IsAssignableTo(t));
    }

    private TsTypesGenerator WriteType(Type type)
    {
        return this.WriteType(type, false, null);
    }

    private TsTypesGenerator WriteType(Type type, ICustomAttributeProvider? owner = null)
    {
        return this.WriteType(type, false, owner);
    }

    private TsTypesGenerator WriteType(Type type, bool isDecl = false, ICustomAttributeProvider? owner = null)
    {
        // this.NullabilityInfoContext.Create()
        if (PrimitiveTypes.TryGetValue(type, out var primType))
        {
            return this.WriteExpression(primType);
        }

        if (!type.IsGenericParameter && this.IsAny(type))
        {
            return this.WriteExpression("any");
        }

        if (type.IsArray)
        {
            Assert.False(isDecl);
            Verify.True(type.GetArrayRank() == 1, "Arrays of high rank are not supported.");
            return this.WriteExpression("(").WriteType(type.GetElementType()!, isDecl, owner).WriteExpression(")[]");
        }

        if (type.IsGenericType && type.GetGenericTypeDefinition() is { } gType)
        {
            if (gType == typeof(Nullable<>))
            {
                Assert.False(isDecl);
                return this.WriteExpression("(").WriteType(type.GetGenericArguments().Single(), isDecl, owner).WriteExpression(") | null");
            }
            if (gType.IsAssignableTo(typeof(IReadOnlyList<>)) || gType == typeof(IEnumerable<>))
            {
                Assert.False(isDecl);
                var elementType = type.GetInterfaces().Prepend(type).Single(t => t.IsGenericType && t.GetGenericTypeDefinition() == typeof(IEnumerable<>)).GetGenericArguments().Single();
                return this.WriteExpression("(").WriteType(elementType, isDecl, owner).WriteExpression(")[]");
            }
        }

        this.WriteTypeName(type);

        if (type.IsGenericType)
        {
            this.WriteExpression("<");
            var Comma = this.Separator(", ");
            foreach (var genericArg in type.GetGenericArguments())
            {
                this.Write(Comma)
                    .WriteType(genericArg, genericArg);
                if (isDecl && this.IsAny(genericArg))
                {
                    this.WriteExpression(" = any");
                }
            }
            this.WriteExpression(">");
        }

        return this;
    }

    private TsTypesGenerator WriteClass(Type type)
    {
        if (type.IsGenericType)
        {
            type = type.GetGenericTypeDefinition();
        }

        this.WriteStatement($"export interface ", true)
            .WriteType(type, true);

        if (type.BaseType != typeof(object) && type.BaseType != typeof(ValueType) && type.BaseType != null)
        {
            this.WriteExpression($" extends ")
                .WriteType(type.BaseType);
        }

        using (this.WriteBlock())
        {
            foreach (var prop in type.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly))
            {
                if (prop.GetCustomAttribute<JsonIgnoreAttribute>() is not null)
                {
                    continue;
                }
                this.WriteStatement($"{prop.Name}: ")
                    .WriteType(prop.PropertyType, prop)
                    .WriteSemi();
            }

            foreach (var field in type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly))
            {
                this.WriteStatement($"{field.Name}: ")
                    .WriteType(field.FieldType, field)
                    .WriteSemi();
            }
        }
        return this;
    }

    private TsTypesGenerator WriteEnum(Type type)
    {
        this.WriteStatement("export type ", true)
            .WriteTypeName(type)
            .WriteExpression(" = ");

        var Or = this.Separator(" | ");

        foreach (var mem in type.GetEnumNames())
        {
            this.Write(Or).WriteExpression(@$"""{mem}""");
        }

        return this.WriteSemi();
    }

    public TsTypesGenerator WriteSingleType(Type type)
    {
        switch (type)
        {
            case { IsEnum: true }:
                return this.WriteEnum(type);
            case { IsClass: true } or { IsValueType: true, IsPrimitive: false, IsEnum: false }:
                return this.WriteClass(type);
            default:
                throw Verify.FailArg(nameof(type));
        }
    }

    public TsTypesGenerator WriteTypesOfAssembly(Assembly assembly)
    {
        foreach (var (type, attrib) in assembly.GetExportedTypes().WithCustomAttribute<GenerateTsAttribute>(false))
        {
            this.WriteSingleType(type);
        }
        return this;
    }

    public TsTypesGenerator WriteAliases()
    {
        var first = true;
        foreach (var (fromType, alias) in this.Config.Aliases)
        {
            this.WriteStatement("export type ", first)
                .WriteTypeName(fromType)
                .WriteExpression(" = ")
                .WriteType(alias.ToType)
                .WriteSemi();
            first = false;
        }
        return this;
    }

    public TsTypesGenerator WriteDefaultTypes()
    {
        this.WriteStatement("declare global", true);
        using (this.WriteBlock())
        {
            this.WriteStatement("type integer = number", true).WriteSemi();
            this.WriteStatement("type long = number").WriteSemi();
            this.WriteStatement("type short = number").WriteSemi();
            this.WriteStatement("type sbyte = number").WriteSemi();

            this.WriteStatement("type uinteger = number", true).WriteSemi();
            this.WriteStatement("type ulong = number").WriteSemi();
            this.WriteStatement("type ushort = number").WriteSemi();
            this.WriteStatement("type byte = number").WriteSemi();

            this.WriteStatement("type single = number", true).WriteSemi();
            this.WriteStatement("type double = number").WriteSemi();
            this.WriteStatement("type decimal = number").WriteSemi();
        }
        return this;
    }

    public void Dispose()
    {
        this.FinishBefore();
        if (this.NoWriterDispose)
        {
            this.Writer.Flush();
        }
        else
        {
            this.Writer.Dispose();
        }
    }

    public TextWriter Writer { get; }
    public bool NoWriterDispose { get; init; } = false;
    public Configuration Config { get; }

    private bool sthBefore = false;
    private int indentLevel = 0;

    private static readonly IReadOnlyDictionary<Type, string> PrimitiveTypes = new Dictionary<Type, string>()
    {
        [typeof(int)] = "integer",
        [typeof(long)] = "long",
        [typeof(short)] = "short",
        [typeof(sbyte)] = "sbyte",

        [typeof(uint)] = "uinteger",
        [typeof(ulong)] = "ulong",
        [typeof(ushort)] = "ushort",
        [typeof(byte)] = "byte",

        [typeof(float)] = "single",
        [typeof(double)] = "double",
        [typeof(decimal)] = "decimal",

        [typeof(bool)] = "boolean",
        [typeof(string)] = "string",
    };

    private static readonly IReadOnlyList<Type> AnyTypes = new Type[] {
        typeof(OpenXmlElement),
    };

    private readonly NullabilityInfoContext NullabilityInfoContext = new();

    public record struct TypeAlias(Type ToType)
    {
        public string? Name { get; init; } = null;
    }

    public record class Configuration
    {
        public bool AutoFlush { get; set; } = true;
        public Dictionary<Type, TypeAlias> Aliases { get; } = new();
    }
}

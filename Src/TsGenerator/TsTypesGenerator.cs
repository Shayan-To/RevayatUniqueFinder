using System.Reflection;

public class TsTypesGenerator
{
    public TsTypesGenerator(TextWriter writer)
    {
        this.Writer = writer;
    }

    private bool FinishBefore()
    {
        if (this.sthBefore)
        {
            this.Writer.WriteLine();
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

    private string NormalizeTypeName(string name)
    {
        return name.RegexReplace(@"`\d+$", "");
    }

    private bool IsAny(Type type)
    {
        return AnyTypes.Any(t => type.IsAssignableTo(t));
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
        if (PrimitiveTypes.TryGetValue(type, out var primType))
        {
            Verify.NonNull(primType);
            return this.WriteExpression(primType);
        }

        if (!type.IsGenericParameter && this.IsAny(type))
        {
            return this.WriteExpression("any");
        }



        this.WriteExpression(this.NormalizeTypeName(type.Name));

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

        if (type.BaseType != typeof(object) && type.BaseType != null)
        {
            this.WriteExpression($" extends ")
                .WriteType(type.BaseType);
        }

        using (this.WriteBlock())
        {
            foreach (var prop in type.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly))
            {
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
        this.WriteStatement($"export type {type.Name} = ", true);

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
            case { IsClass: true }:
                return this.WriteClass(type);
            case { IsEnum: true }:
                return this.WriteEnum(type);
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

    public TsTypesGenerator WriteDefaultTypes()
    {
        this.WriteStatement("declare global", true);
        using (this.WriteBlock())
        {
            this.WriteStatement("type integer = number").WriteSemi();
            this.WriteStatement("type long = number").WriteSemi();
            this.WriteStatement("type short = number").WriteSemi();
            this.WriteStatement("type sbyte = number").WriteSemi();

            this.WriteStatement("type uinteger = number").WriteSemi();
            this.WriteStatement("type ulong = number").WriteSemi();
            this.WriteStatement("type ushort = number").WriteSemi();
            this.WriteStatement("type byte = number").WriteSemi();

            this.WriteStatement("type single = number").WriteSemi();
            this.WriteStatement("type double = number").WriteSemi();
            this.WriteStatement("type decimal = number").WriteSemi();
        }
        return this;
    }

    public TextWriter Writer { get; }

    private bool sthBefore = false;
    private int indentLevel = 0;

    private static readonly IReadOnlyDictionary<Type, string?> PrimitiveTypes = new Dictionary<Type, string?>()
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

        [typeof(object)] = null,
    };

    private static readonly IReadOnlyList<Type> AnyTypes = new Type[] {
        typeof(OpenXmlElement),
    };
}

using System.Collections;
using System.Linq.Expressions;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

if (Utilities.False)
{
    DrawChildrenTree();
    return;
}

var serializationOptions = new JsonSerializerOptions()
{
    WriteIndented = true,
    Converters =
    {
        new TypeNameConverter(),
    },
};

var tsGeneratorConfig = new TsTypesGenerator.Configuration()
{
    Aliases =
    {
        [typeof(Type)] = new(typeof(string)) { Name = "CsType" }
    }
};

if (!Directory.Exists(Paths.GenOutput))
{
    Directory.CreateDirectory(Paths.GenOutput);
}
foreach (var d in Directory.EnumerateDirectories(Paths.GenOutput))
{
    Directory.Delete(d, true);
}
foreach (var f in Directory.EnumerateFiles(Paths.GenOutput))
{
    File.Delete(f);
}

var typesFile = Path.Combine(Paths.GenOutput, "types.ts");
using (var writer = new StreamWriter(File.Open(typesFile, FileMode.Create, FileAccess.Write, FileShare.Read)))
{
    using var generator = new TsTypesGenerator(writer, tsGeneratorConfig);
    generator.WriteEslintDisable()
        .WriteDefaultTypes()
        .WriteAliases()
        .WriteTypesOfAssembly(Assembly.GetEntryAssembly()!);
}

var extensionMarker = new ExtensionMarker();
OpenXmlExtensions.AddListener(extensionMarker);

var docName = "Untitled 1.docx";
var doc = WordprocessingDocument.Open(Path.Combine(Paths.Documents, docName), false);
var document = doc.MainDocumentPart?.Document;
Verify.NonNull(document);

var metadataFile = Path.Combine(Paths.GenOutput, "metadata.json");
using (var stream = File.Open(metadataFile, FileMode.Create, FileAccess.Write, FileShare.Read))
{
    JsonSerializer.Serialize(stream, new { OpenXmlExtensions.AttributesData }, serializationOptions);
}

var documentFile = Path.Combine(Paths.GenOutput, "document.json");
using (var stream = File.Open(documentFile, FileMode.Create, FileAccess.Write, FileShare.Read))
{
    JsonSerializer.Serialize(stream, new OutputXml(document, extensionMarker), serializationOptions);
}

static void Traverse(OpenXmlElement element, Action<OpenXmlElement> action)
{
    action.Invoke(element);
    foreach (var ch in element.ChildElements)
    {
        Traverse(ch, action);
    }
}

static void DrawChildrenTree()
{
    var docName = "Untitled 1.docx";
    var doc = WordprocessingDocument.Open(Path.Combine(Paths.Documents, docName), false);
    var document = doc.MainDocumentPart!.Document;

    var treeDrawer = ConsoleTreeDrawer<Type>.CreateFromChildren(new OpenXmlElement[] { document }, e => e.ChildElements, e => e.GetType());

    foreach (var l in treeDrawer.MakeTree())
    {
        Console.WriteLine(l);
    }
}

// static class Exts
// {
//     private const BindingFlags Bf_Instance = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;

//     static Exts()
//     {
//         var tp_OpenXmlElement = typeof(OpenXmlElement);
//         var pr_ParsedState = tp_OpenXmlElement.GetProperty("ParsedState", Bf_Instance);
//         Assert.NonNull(pr_ParsedState);
//         var pr_Attributes = pr_ParsedState.PropertyType.GetProperty("Attributes", Bf_Instance);
//         Assert.NonNull(pr_Attributes);
//         var tp_AttributeCollection = pr_Attributes.PropertyType;
//         var fl__data = tp_AttributeCollection.GetField("_data", Bf_Instance);
//         Assert.NonNull(fl__data);

//         var element = Expression.Parameter(tp_OpenXmlElement, "element");
//         var parsedState = Expression.Property(element, pr_ParsedState);
//         var attributes = Expression.Property(parsedState, pr_Attributes);
//         var data = Expression.Field(attributes, fl__data);
//         var lambda = Expression.Lambda<Func<OpenXmlElement, OpenXmlSimpleType?[]>>(data, nameof(DynGetAttrsArray), new[] { element });
//         Element_GetAttrsArray = lambda.Compile();

//         var collection = Expression.Parameter(typeof(IEnumerable), "collection");
//         var data2 = Expression.Field(Expression.Convert(collection, tp_AttributeCollection), fl__data);
//         var lambda2 = Expression.Lambda<Func<IEnumerable, OpenXmlSimpleType?[]>>(data2, nameof(DynGetAttrsArray), new[] { collection });
//         Collection_GetAttrsArray = lambda2.Compile();
//     }

//     private static readonly Func<OpenXmlElement, OpenXmlSimpleType?[]> Element_GetAttrsArray;
//     public static OpenXmlSimpleType?[] DynGetAttrsArray(this OpenXmlElement element)
//     {
//         return Element_GetAttrsArray.Invoke(element);
//     }

//     private static readonly Func<IEnumerable, OpenXmlSimpleType?[]> Collection_GetAttrsArray;
//     public static OpenXmlSimpleType?[] DynGetAttrsArray(this IEnumerable collection)
//     {
//         return Collection_GetAttrsArray.Invoke(collection);
//     }

//     public static readonly Harmony harmony = new(Assembly.GetEntryAssembly()!.GetName().Name);
// }

public class TypeNameConverter : JsonConverter<Type>
{
    public override Type? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        Assert.True(typeToConvert == typeof(Type));
        throw new NotSupportedException();
    }

    public override void Write(Utf8JsonWriter writer, Type value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value.FullName, options);
    }
}

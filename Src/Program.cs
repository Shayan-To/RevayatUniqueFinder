using System.Collections;
using System.Linq.Expressions;
using System.Reflection;
using System.Text.Json;

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

var False = false;
var True = true;

if (False)
{
    DrawChildrenTree();
}
if (False)
{
    GenerateTypes();
}
if (True)
{
    Test();
}

static void Test()
{
    var body = ReadBody();

    JsonSerializer.Serialize(Console.OpenStandardOutput(), new OutputXml(body, new()), new JsonSerializerOptions() { WriteIndented = true });

    // Traverse(body, el => {
    //     Patches.ElArrayToElement.Add(el.DynGetAttrsArray(), el);
    // });

    // Console.WriteLine(body.DynGetAttrsArray().AllToString());
}

static void Traverse(OpenXmlElement element, Action<OpenXmlElement> action)
{
    action.Invoke(element);
    foreach (var ch in element.ChildElements)
    {
        Traverse(ch, action);
    }
}

static void GenerateTypes()
{
    var basePath = Paths.GenOutput;
    var typesFile = Path.Combine($"{basePath}", "types.ts");

    if (Directory.Exists(basePath))
    {
        Directory.Delete(basePath, true);
    }
    Directory.CreateDirectory(basePath);

    using var writer = new StreamWriter(File.Open(typesFile, FileMode.Create, FileAccess.Write, FileShare.Read));
    var generator = new TsTypesGenerator(writer);
    generator.WriteDefaultTypes()
        .WriteTypesOfAssembly(Assembly.GetEntryAssembly()!);
}

static void DrawChildrenTree()
{
    var body = ReadBody();
    var treeDrawer = ConsoleTreeDrawer<Type>.CreateFromChildren(new OpenXmlElement[] { body }, e => e.ChildElements, e => e.GetType());

    foreach (var l in treeDrawer.MakeTree())
    {
        Console.WriteLine(l);
    }
}

static Body ReadBody()
{
    var docName = "Untitled 1.docx";
    var doc = WordprocessingDocument.Open(Path.Combine(Paths.Documents, docName), false);
    var body = doc.MainDocumentPart?.Document.Body;
    Verify.NonNull(body);
    return body;
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

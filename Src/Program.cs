using DocumentFormat.OpenXml.Packaging;

void GenerateTypes()
{
    var basePath = Paths.GenOutput;
    var typesFile = Path.Combine($"{basePath}", "types.ts");

    if (!Directory.Exists(basePath))
    {
        Directory.Delete(basePath, true);
    }
    Directory.CreateDirectory(basePath);

    using var writer = new StreamWriter(File.Open(typesFile, FileMode.Create, FileAccess.Write, FileShare.Read));
}

var doc = WordprocessingDocument.Open(Path.Combine(Paths.Documents, "وسائل الشيعة.docx"), false);

var body = doc.MainDocumentPart?.Document.Body;

Verify.NonNull(body);

DrawChildrenTree(body);

static void DrawChildrenTree(OpenXmlElement body)
{
    var treeDrawer = ConsoleTreeDrawer<Type>.CreateFromChildren(new OpenXmlElement[] { body }, e => e.ChildElements, e => e.GetType());

    foreach (var l in treeDrawer.MakeTree())
    {
        Console.WriteLine(l);
    }
}

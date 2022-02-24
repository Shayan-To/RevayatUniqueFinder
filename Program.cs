using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;

using Ks.Common;

using RevayatUniqueFinder;

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

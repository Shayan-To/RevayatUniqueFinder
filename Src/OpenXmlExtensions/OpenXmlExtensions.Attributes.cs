using System.Collections.ObjectModel;

namespace RevayatUniqueFinder;

static partial class OpenXmlExtensions
{
    private static void EnsureMetadata(OpenXmlElement element)
    {
        if (_AttributesDataDic.ContainsKey(element.GetType()))
        {
            return;
        }

        var elementMetadata = DocumentFormat.OpenXml.Framework.Metadata.ElementMetadata.Create(element);
        Assert.True(element.GetType() == elementMetadata.Type);
        var dic = _AttributesDataDic[elementMetadata.Type] = new();

        if (elementMetadata.Type == typeof(DocumentFormat.OpenXml.Wordprocessing.Document))
        {
            var d = new AttributeData(typeof(DocumentFormat.OpenXml.Wordprocessing.Document), typeof(DocumentFormat.OpenXml.StringValue), new("IgnorablePrefixes", "Ignorable", "http://schemas.openxmlformats.org/markup-compatibility/2006", "mc"));
            AttributesData.Add(d);
            dic.Add((d.Name.NamespaceUri, d.Name.XmlName), d);
        }

        foreach (var att in elementMetadata.Attributes)
        {
            var d = new AttributeData(elementMetadata.Type, att.Type, new(att.PropertyName, att.QName.Name, att.QName.Namespace.Uri, att.QName.Namespace.Prefix));
            AttributesData.Add(d);
            dic.Add((d.Name.NamespaceUri, d.Name.XmlName), d);
        }
    }

    public static IEnumerable<AttributeValue> GetXAttributes(this OpenXmlElement element)
    {
        EnsureMetadata(element);
        var elementType = element.GetType();
        return element.GetAttributes().Select(att => new AttributeValue(_AttributesDataDic[elementType][(att.NamespaceUri, att.LocalName)].Name, att.Value));
    }

    private static Dictionary<Type, Dictionary<(string NamespaceUri, string LocalName), AttributeData>> _AttributesDataDic = new();
    public static List<AttributeData> AttributesData = new();

    [GenerateTs]
    public record class AttributeData(Type ElementType, Type AttributeType, XmlQualifiedName Name);
    [GenerateTs]
    public readonly record struct AttributeValue(XmlQualifiedName Name, string? Value);
}

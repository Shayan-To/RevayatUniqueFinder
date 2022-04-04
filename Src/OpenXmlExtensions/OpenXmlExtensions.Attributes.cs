using System.Collections.ObjectModel;

namespace RevayatUniqueFinder;

static partial class OpenXmlExtensions
{
    static OpenXmlExtensions()
    {
        var list = AttributesData.Prepend(new(typeof(DocumentFormat.OpenXml.Wordprocessing.Document), typeof(DocumentFormat.OpenXml.StringValue), new("IgnorablePrefixes", "Ignorable", "http://schemas.openxmlformats.org/markup-compatibility/2006", "mc")));
        _AttributesDataDic = new(list.ToDictionary(d => (d.ElementType, d.Name.NamespaceUri, d.Name.XmlName)));
    }

    public static IEnumerable<AttributeValue> GetXAttributes(this OpenXmlElement element)
    {
        var elementType = element.GetType();
        return element.GetAttributes().Select(att => new AttributeValue(_AttributesDataDic[(elementType, att.NamespaceUri, att.LocalName)].Name, att.Value));
    }

    private static ReadOnlyDictionary<(Type ElementType, string NamespaceUri, string LocalName), AttributeData> _AttributesDataDic;

    [GenerateTs]
    public record class AttributeData(Type ElementType, Type AttributeType, XmlQualifiedName Name);
    [GenerateTs]
    public readonly record struct AttributeValue(XmlQualifiedName Name, string? Value);
}

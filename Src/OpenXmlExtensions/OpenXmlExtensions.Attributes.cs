using System.Collections.ObjectModel;

namespace RevayatUniqueFinder;

static partial class OpenXmlExtensions
{
    static OpenXmlExtensions()
    {
        _AttributesDataDic = new(AttributesData.ToDictionary(d =>
        {
            return (d.ElementType, d.Name.NamespaceUri, d.Name.Name);
        }));
    }

    public static IEnumerable<AttributeValue> GetXAttributes(this OpenXmlElement element)
    {
        var elementType = element.GetType();
        return element.GetAttributes().Select(att => new AttributeValue(_AttributesDataDic[(elementType, att.NamespaceUri, att.LocalName)].Name, att.Value));
    }

    private static ReadOnlyDictionary<(Type ElementType, string NamespaceUri, string LocalName), AttributeData> _AttributesDataDic;

    public readonly record struct AttributeData(Type ElementType, Type AttributeType, XmlQualifiedName Name);
    public readonly record struct AttributeValue(XmlQualifiedName Name, string? Value);
}

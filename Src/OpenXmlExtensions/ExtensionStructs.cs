using System.Text.Json.Serialization;

namespace RevayatUniqueFinder;

public readonly record struct ExtensionElement<TElement>(TElement Element) where TElement : OpenXmlElement
{
    public static implicit operator ExtensionElement<OpenXmlElement>(ExtensionElement<TElement> element)
    {
        return new(element.Element);
    }
}

[GenerateTs]
public readonly record struct ExtensionValue<T>(T Value, ExtensionValueSource Source);

[GenerateTs]
public readonly record struct ExtensionValueSource([property: JsonIgnore] ExtensionElement<OpenXmlElement> Element, ExtensionValueSourceType Type, XmlQualifiedName? Attribute = null)
{
    public int ElementId => ReferenceEqualityComparer<OpenXmlElement>.Instance.GetHashCode(this.Element.Element);
}

[GenerateTs]
public readonly record struct XmlQualifiedName(string Name, string XmlName, string NamespaceUri, string NamespacePrefix);

[GenerateTs]
public enum ExtensionValueSourceType
{
    Content,
    Attribute,
}

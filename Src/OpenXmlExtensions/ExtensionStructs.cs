namespace RevayatUniqueFinder;

public readonly record struct ExtensionElement<TElement>(TElement Element) where TElement : OpenXmlElement
{
    public static implicit operator ExtensionElement<OpenXmlElement>(ExtensionElement<TElement> element)
    {
        return new(element.Element);
    }
}

public readonly record struct ExtensionValue<T>(T Value, ExtensionValueSource Source);

public readonly record struct ExtensionValueSource(ExtensionElement<OpenXmlElement> Element, ExtensionValueSourceType Type, XmlQualifiedName? Attribute = null);

public readonly record struct XmlQualifiedName(string Name, string XmlName, string NamespaceUri, string NamespacePrefix);

public enum ExtensionValueSourceType
{
    Content,
    Attribute,
}

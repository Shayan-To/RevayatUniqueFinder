namespace RevayatUniqueFinder;

public record struct ExtensionElement<TElement> where TElement : OpenXmlElement
{
    public ExtensionElement(TElement element)
    {
        this.Element = element;
    }

    public static implicit operator ExtensionElement<OpenXmlElement>(ExtensionElement<TElement> element)
    {
        return new(element.Element);
    }

    public TElement Element { get; }
}

public record struct ExtensionValue<T>
{
    public ExtensionValue(T value, ExtensionValueSource source)
    {
        this.Value = value;
        this.Source = source;
    }

    public T Value { get; }
    public ExtensionValueSource Source { get; }
}

public record struct ExtensionValueSource
{
    public ExtensionValueSource(ExtensionElement<OpenXmlElement> element, ExtensionValueSourceType type, XmlQualifiedName? attribute = null)
    {
        this.Element = element;
        this.Type = type;
        this.Attribute = attribute;
    }

    public ExtensionElement<OpenXmlElement> Element { get; }
    public ExtensionValueSourceType Type { get; }
    public XmlQualifiedName? Attribute { get; }
}

public record struct XmlQualifiedName
{
    public XmlQualifiedName(string propertyName, string name, string namespaceUri, string namespacePrefix)
    {
        this.PropertyName = propertyName;
        this.Name = name;
        this.NamespaceUri = namespaceUri;
        this.NamespacePrefix = namespacePrefix;
    }

    public string PropertyName { get; }
    public string Name { get; }
    public string NamespaceUri { get; }
    public string NamespacePrefix { get; }
}

public enum ExtensionValueSourceType
{
    Content,
    Attribute,
}

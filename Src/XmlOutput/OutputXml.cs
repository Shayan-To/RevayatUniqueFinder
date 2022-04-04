using System.Text.Json.Serialization;

namespace RevayatUniqueFinder;

[GenerateTs(Name = "XmlElement")]
public class OutputXml
{
    public OutputXml(OpenXmlElement element, ExtensionMarker marker)
    {
        this.Element = element;
        this.Marker = marker;
    }

    public XmlQualifiedName Name => new(this.Element.GetType().FullName ?? "", this.Element.LocalName, this.Element.NamespaceUri, this.Element.Prefix);
    public Accessable<string?> Content => new(this.Element is OpenXmlLeafTextElement e ? e.Text : null, this.Marker.AccessedContent.Contains(this.Element));
    public IEnumerable<Accessable<OpenXmlExtensions.AttributeValue>> Attributes => this.Element.GetXAttributes().Select(att => new Accessable<OpenXmlExtensions.AttributeValue>(att, this.Marker.AccessedAttributes[this.Element].Contains(att.Name)));
    public IEnumerable<Accessable<OutputXml>> Children => this.Element.ChildElements.Select(ch => new Accessable<OutputXml>(new(ch, this.Marker), this.Marker.AccessedChildren[this.Element].Contains(ch)));

    public int ElementId => ReferenceEqualityComparer<OpenXmlElement>.Instance.GetHashCode(this.Element);

    [JsonIgnore]
    public OpenXmlElement Element { get; }
    [JsonIgnore]
    public ExtensionMarker Marker { get; }

    [GenerateTs]
    public readonly record struct Accessable<T>(T Value, bool IsAccessed);
}

namespace RevayatUniqueFinder;

public class ExtensionMarker : ExtensionListener
{
    public override void OnAttributeAccess(ExtensionElement<OpenXmlElement> element, XmlQualifiedName name, ExtensionValue<OpenXmlSimpleType> value)
    {
        if (!this.IsEnabled)
        {
            return;
        }
        this.AccessedAttributes[element.Element].Add(name);
    }

    public override void OnChildAccess(ExtensionElement<OpenXmlElement> element, ExtensionElement<OpenXmlElement> child)
    {
        if (!this.IsEnabled)
        {
            return;
        }
        this.AccessedChildren[element.Element].Add(child.Element);
    }

    public override void OnContentAccess(ExtensionElement<OpenXmlElement> element, ExtensionValue<string> value)
    {
        if (!this.IsEnabled)
        {
            return;
        }
        this.AccessedContent.Add(element.Element);
    }

    public bool IsEnabled { get; set; } = false;
    public HashSet<OpenXmlElement> AccessedContent { get; } = new();
    public CreateInstanceDictionary<OpenXmlElement, HashSet<XmlQualifiedName>> AccessedAttributes { get; } = CreateInstanceDictionary.Create<OpenXmlElement, HashSet<XmlQualifiedName>>();
    public CreateInstanceDictionary<OpenXmlElement, HashSet<OpenXmlElement>> AccessedChildren { get; } = CreateInstanceDictionary.Create<OpenXmlElement, HashSet<OpenXmlElement>>();
}

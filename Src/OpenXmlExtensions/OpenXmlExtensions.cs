namespace RevayatUniqueFinder;

public static partial class OpenXmlExtensions
{
    public static ExtensionElement<TElement> Wrap<TElement>(this TElement element)
        where TElement : OpenXmlElement
    {
        return new(element);
    }

    private static ExtensionValue<T> GetAttribute<TElement, T>(this ExtensionElement<TElement> element, XmlQualifiedName name)
        where TElement : OpenXmlElement where T : OpenXmlSimpleType, new()
    {
        var att = element.Element.GetAttribute(name.Name, name.NamespaceUri);
        var res = new ExtensionValue<T>(new() { InnerText = att.Value }, new(element, ExtensionValueSourceType.Attribute, name));
        Listeners.OnAttributeAccess(element, name, new(res.Value, res.Source));
        return res;
    }

    private static IEnumerable<ExtensionElement<TChildren>> GetChildren<TElement, TChildren>(this ExtensionElement<TElement> element)
        where TElement : OpenXmlElement where TChildren : OpenXmlElement
    {
        return element.Element.ChildElements.OfType<TChildren>().Select(ch => ChildSelector(element, ch));
    }

    public static IEnumerable<ExtensionElement<OpenXmlElement>> Children(this ExtensionElement<OpenXmlElement> element)
    {
        return element.Element.ChildElements.Select(ch => ChildSelector(element, ch));
    }

    private static ExtensionElement<TElement> ChildSelector<TElement>(ExtensionElement<OpenXmlElement> element, TElement ch)
        where TElement : OpenXmlElement
    {
        Listeners.OnChildAccess(element, new(ch));
        return new(ch);
    }

    public static ExtensionValue<string> Content<TElement>(this ExtensionElement<TElement> element)
        where TElement : OpenXmlLeafTextElement
    {
        var res = new ExtensionValue<string>(element.Element.Text, new(element, ExtensionValueSourceType.Content));
        Listeners.OnContentAccess(element, res);
        return res;
    }

    public static void AddListener(ExtensionListener listener)
    {
        Listeners.Listeners.Add(listener);
    }

    public static void RemoveListener(ExtensionListener listener)
    {
        Listeners.Listeners.Remove(listener);
    }

    private static readonly ExtensionListenerList Listeners = new();
}

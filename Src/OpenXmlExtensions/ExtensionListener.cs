namespace RevayatUniqueFinder;

public abstract class ExtensionListener
{
    public abstract void OnAttributeAccess(ExtensionElement<OpenXmlElement> element, XmlQualifiedName name, ExtensionValue<OpenXmlSimpleType> value);
    public abstract void OnContentAccess(ExtensionElement<OpenXmlElement> element, ExtensionValue<string> value);
    public abstract void OnChildAccess(ExtensionElement<OpenXmlElement> element, ExtensionElement<OpenXmlElement> child);
}

public class LambdaExtensionListener : ExtensionListener
{
    public LambdaExtensionListener(Action<ExtensionElement<OpenXmlElement>, XmlQualifiedName, ExtensionValue<OpenXmlSimpleType>> onAttributeAccess, Action<ExtensionElement<OpenXmlElement>, ExtensionElement<OpenXmlElement>> onChildAccess, Action<ExtensionElement<OpenXmlElement>, ExtensionValue<string>> onContentAccess)
    {
        this._OnAttributeAccess = onAttributeAccess;
        this._OnChildAccess = onChildAccess;
        this._OnContentAccess = onContentAccess;
    }

    public override void OnAttributeAccess(ExtensionElement<OpenXmlElement> element, XmlQualifiedName name, ExtensionValue<OpenXmlSimpleType> value)
    {
        this._OnAttributeAccess.Invoke(element, name, value);
    }

    public override void OnChildAccess(ExtensionElement<OpenXmlElement> element, ExtensionElement<OpenXmlElement> child)
    {
        this._OnChildAccess.Invoke(element, child);
    }

    public override void OnContentAccess(ExtensionElement<OpenXmlElement> element, ExtensionValue<string> value)
    {
        this._OnContentAccess.Invoke(element, value);
    }

    private readonly Action<ExtensionElement<OpenXmlElement>, XmlQualifiedName, ExtensionValue<OpenXmlSimpleType>> _OnAttributeAccess;
    private readonly Action<ExtensionElement<OpenXmlElement>, ExtensionElement<OpenXmlElement>> _OnChildAccess;
    private readonly Action<ExtensionElement<OpenXmlElement>, ExtensionValue<string>> _OnContentAccess;
}

public class ExtensionListenerList : ExtensionListener
{
    public ExtensionListenerList()
    {
    }

    public ExtensionListenerList(IEnumerable<ExtensionListener> listeners)
    {
        this.Listeners.AddRange(listeners);
    }

    public override void OnAttributeAccess(ExtensionElement<OpenXmlElement> element, XmlQualifiedName name, ExtensionValue<OpenXmlSimpleType> value)
    {
        foreach (var l in this.Listeners)
        {
            l.OnAttributeAccess(element, name, value);
        }
    }

    public override void OnChildAccess(ExtensionElement<OpenXmlElement> element, ExtensionElement<OpenXmlElement> child)
    {
        foreach (var l in this.Listeners)
        {
            l.OnChildAccess(element, child);
        }
    }

    public override void OnContentAccess(ExtensionElement<OpenXmlElement> element, ExtensionValue<string> value)
    {
        foreach (var l in this.Listeners)
        {
            l.OnContentAccess(element, value);
        }
    }

    public List<ExtensionListener> Listeners { get; } = new();
}

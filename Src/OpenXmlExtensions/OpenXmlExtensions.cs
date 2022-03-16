namespace RevayatUniqueFinder;

public static partial class OpenXmlExtensions
{
    private static T GetAttribute<T>(this OpenXmlElement element, string propertyName, string namespaceUri, string localName) where T : OpenXmlSimpleType, new()
    {
        Utilities.DoNothing(propertyName);
        var att = element.GetAttribute(localName, namespaceUri);
        var val = new T();
        val.InnerText = att.Value;
        return val;
    }

    private static IEnumerable<T> GetChildren<T>(this OpenXmlElement element) where T : OpenXmlElement
    {
        return element.ChildElements.OfType<T>();
    }
}

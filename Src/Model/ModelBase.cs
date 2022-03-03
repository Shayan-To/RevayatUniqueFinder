namespace RevayatUniqueFinder;

[GenerateTs]
public class ModelBase<TXml> where TXml : OpenXmlElement
{
    public TXml XmlElement { get; init; } = null!;
}
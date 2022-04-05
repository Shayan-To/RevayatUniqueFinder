namespace RevayatUniqueFinder;

public class Convertor
{
    public Document ConvertDocument(ExtensionElement<Word.Document> el)
    {
        var body = el.CollectBodys().Single();
        return null!;
    }
}

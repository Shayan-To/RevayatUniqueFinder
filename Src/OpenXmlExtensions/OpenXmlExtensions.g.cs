namespace RevayatUniqueFinder;

// Generated for type DocumentFormat.OpenXml.Wordprocessing.Paragraph
static partial class OpenXmlExtensions
{
    public static ExtensionValue<DocumentFormat.OpenXml.HexBinaryValue> GetRsidParagraphMarkRevision(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Paragraph> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.Paragraph, DocumentFormat.OpenXml.HexBinaryValue>(new("RsidParagraphMarkRevision", "rsidRPr", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.HexBinaryValue> GetRsidParagraphAddition(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Paragraph> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.Paragraph, DocumentFormat.OpenXml.HexBinaryValue>(new("RsidParagraphAddition", "rsidR", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.HexBinaryValue> GetRsidParagraphDeletion(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Paragraph> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.Paragraph, DocumentFormat.OpenXml.HexBinaryValue>(new("RsidParagraphDeletion", "rsidDel", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.HexBinaryValue> GetRsidParagraphProperties(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Paragraph> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.Paragraph, DocumentFormat.OpenXml.HexBinaryValue>(new("RsidParagraphProperties", "rsidP", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.HexBinaryValue> GetRsidRunAdditionDefault(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Paragraph> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.Paragraph, DocumentFormat.OpenXml.HexBinaryValue>(new("RsidRunAdditionDefault", "rsidRDefault", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.HexBinaryValue> GetParagraphId(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Paragraph> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.Paragraph, DocumentFormat.OpenXml.HexBinaryValue>(new("ParagraphId", "paraId", "http://schemas.microsoft.com/office/word/2010/wordml", "w14"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.HexBinaryValue> GetTextId(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Paragraph> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.Paragraph, DocumentFormat.OpenXml.HexBinaryValue>(new("TextId", "textId", "http://schemas.microsoft.com/office/word/2010/wordml", "w14"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.OnOffValue> GetNoSpellError(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Paragraph> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.Paragraph, DocumentFormat.OpenXml.OnOffValue>(new("NoSpellError", "noSpellErr", "http://schemas.microsoft.com/office/word/2010/wordml", "w14"));
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride>> CollectBidirectionalOverrides(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Paragraph> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Paragraph, DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd>> CollectBookmarkEnds(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Paragraph> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Paragraph, DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.BookmarkStart>> CollectBookmarkStarts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Paragraph> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Paragraph, DocumentFormat.OpenXml.Wordprocessing.BookmarkStart>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd>> CollectCommentRangeEnds(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Paragraph> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Paragraph, DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart>> CollectCommentRangeStarts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Paragraph> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Paragraph, DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ContentPart>> CollectContentParts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Paragraph> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Paragraph, DocumentFormat.OpenXml.Wordprocessing.ContentPart>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun>> CollectCustomXmlRuns(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Paragraph> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Paragraph, DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd>> CollectCustomXmlDelRangeEnds(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Paragraph> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Paragraph, DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart>> CollectCustomXmlDelRangeStarts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Paragraph> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Paragraph, DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd>> CollectCustomXmlInsRangeEnds(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Paragraph> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Paragraph, DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart>> CollectCustomXmlInsRangeStarts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Paragraph> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Paragraph, DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd>> CollectCustomXmlMoveFromRangeEnds(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Paragraph> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Paragraph, DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart>> CollectCustomXmlMoveFromRangeStarts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Paragraph> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Paragraph, DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd>> CollectCustomXmlMoveToRangeEnds(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Paragraph> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Paragraph, DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart>> CollectCustomXmlMoveToRangeStarts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Paragraph> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Paragraph, DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.DeletedRun>> CollectDeletedRuns(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Paragraph> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Paragraph, DocumentFormat.OpenXml.Wordprocessing.DeletedRun>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.BidirectionalEmbedding>> CollectBidirectionalEmbeddings(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Paragraph> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Paragraph, DocumentFormat.OpenXml.Wordprocessing.BidirectionalEmbedding>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.SimpleField>> CollectSimpleFields(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Paragraph> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Paragraph, DocumentFormat.OpenXml.Wordprocessing.SimpleField>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Hyperlink>> CollectHyperlinks(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Paragraph> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Paragraph, DocumentFormat.OpenXml.Wordprocessing.Hyperlink>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.InsertedRun>> CollectInsertedRuns(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Paragraph> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Paragraph, DocumentFormat.OpenXml.Wordprocessing.InsertedRun>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.MoveFromRun>> CollectMoveFromRuns(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Paragraph> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Paragraph, DocumentFormat.OpenXml.Wordprocessing.MoveFromRun>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd>> CollectMoveFromRangeEnds(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Paragraph> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Paragraph, DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart>> CollectMoveFromRangeStarts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Paragraph> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Paragraph, DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.MoveToRun>> CollectMoveToRuns(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Paragraph> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Paragraph, DocumentFormat.OpenXml.Wordprocessing.MoveToRun>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd>> CollectMoveToRangeEnds(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Paragraph> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Paragraph, DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart>> CollectMoveToRangeStarts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Paragraph> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Paragraph, DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties>> CollectParagraphPropertiess(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Paragraph> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Paragraph, DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.PermEnd>> CollectPermEnds(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Paragraph> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Paragraph, DocumentFormat.OpenXml.Wordprocessing.PermEnd>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.PermStart>> CollectPermStarts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Paragraph> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Paragraph, DocumentFormat.OpenXml.Wordprocessing.PermStart>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ProofError>> CollectProofErrors(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Paragraph> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Paragraph, DocumentFormat.OpenXml.Wordprocessing.ProofError>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Run>> CollectRuns(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Paragraph> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Paragraph, DocumentFormat.OpenXml.Wordprocessing.Run>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.SdtRun>> CollectSdtRuns(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Paragraph> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Paragraph, DocumentFormat.OpenXml.Wordprocessing.SdtRun>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.SubDocumentReference>> CollectSubDocumentReferences(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Paragraph> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Paragraph, DocumentFormat.OpenXml.Wordprocessing.SubDocumentReference>();
    }
}

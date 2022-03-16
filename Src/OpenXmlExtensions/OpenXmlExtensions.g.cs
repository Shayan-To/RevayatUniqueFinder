namespace RevayatUniqueFinder;

// Generated for type DocumentFormat.OpenXml.Wordprocessing.Paragraph
static partial class OpenXmlExtensions
{
    public static DocumentFormat.OpenXml.HexBinaryValue GetRsidParagraphMarkRevision(this DocumentFormat.OpenXml.Wordprocessing.Paragraph element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.HexBinaryValue>("RsidParagraphMarkRevision", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "rsidRPr");
    }
    public static DocumentFormat.OpenXml.HexBinaryValue GetRsidParagraphAddition(this DocumentFormat.OpenXml.Wordprocessing.Paragraph element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.HexBinaryValue>("RsidParagraphAddition", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "rsidR");
    }
    public static DocumentFormat.OpenXml.HexBinaryValue GetRsidParagraphDeletion(this DocumentFormat.OpenXml.Wordprocessing.Paragraph element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.HexBinaryValue>("RsidParagraphDeletion", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "rsidDel");
    }
    public static DocumentFormat.OpenXml.HexBinaryValue GetRsidParagraphProperties(this DocumentFormat.OpenXml.Wordprocessing.Paragraph element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.HexBinaryValue>("RsidParagraphProperties", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "rsidP");
    }
    public static DocumentFormat.OpenXml.HexBinaryValue GetRsidRunAdditionDefault(this DocumentFormat.OpenXml.Wordprocessing.Paragraph element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.HexBinaryValue>("RsidRunAdditionDefault", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "rsidRDefault");
    }
    public static DocumentFormat.OpenXml.HexBinaryValue GetParagraphId(this DocumentFormat.OpenXml.Wordprocessing.Paragraph element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.HexBinaryValue>("ParagraphId", "http://schemas.microsoft.com/office/word/2010/wordml", "paraId");
    }
    public static DocumentFormat.OpenXml.HexBinaryValue GetTextId(this DocumentFormat.OpenXml.Wordprocessing.Paragraph element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.HexBinaryValue>("TextId", "http://schemas.microsoft.com/office/word/2010/wordml", "textId");
    }
    public static DocumentFormat.OpenXml.OnOffValue GetNoSpellError(this DocumentFormat.OpenXml.Wordprocessing.Paragraph element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.OnOffValue>("NoSpellError", "http://schemas.microsoft.com/office/word/2010/wordml", "noSpellErr");
    }
    public static IEnumerable<DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride> CollectBidirectionalOverrides(this DocumentFormat.OpenXml.Wordprocessing.Paragraph element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride>();
    }
    public static IEnumerable<DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd> CollectBookmarkEnds(this DocumentFormat.OpenXml.Wordprocessing.Paragraph element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd>();
    }
    public static IEnumerable<DocumentFormat.OpenXml.Wordprocessing.BookmarkStart> CollectBookmarkStarts(this DocumentFormat.OpenXml.Wordprocessing.Paragraph element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.BookmarkStart>();
    }
    public static IEnumerable<DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd> CollectCommentRangeEnds(this DocumentFormat.OpenXml.Wordprocessing.Paragraph element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd>();
    }
    public static IEnumerable<DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart> CollectCommentRangeStarts(this DocumentFormat.OpenXml.Wordprocessing.Paragraph element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart>();
    }
    public static IEnumerable<DocumentFormat.OpenXml.Wordprocessing.ContentPart> CollectContentParts(this DocumentFormat.OpenXml.Wordprocessing.Paragraph element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ContentPart>();
    }
    public static IEnumerable<DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun> CollectCustomXmlRuns(this DocumentFormat.OpenXml.Wordprocessing.Paragraph element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun>();
    }
    public static IEnumerable<DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd> CollectCustomXmlDelRangeEnds(this DocumentFormat.OpenXml.Wordprocessing.Paragraph element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd>();
    }
    public static IEnumerable<DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart> CollectCustomXmlDelRangeStarts(this DocumentFormat.OpenXml.Wordprocessing.Paragraph element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart>();
    }
    public static IEnumerable<DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd> CollectCustomXmlInsRangeEnds(this DocumentFormat.OpenXml.Wordprocessing.Paragraph element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd>();
    }
    public static IEnumerable<DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart> CollectCustomXmlInsRangeStarts(this DocumentFormat.OpenXml.Wordprocessing.Paragraph element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart>();
    }
    public static IEnumerable<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd> CollectCustomXmlMoveFromRangeEnds(this DocumentFormat.OpenXml.Wordprocessing.Paragraph element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd>();
    }
    public static IEnumerable<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart> CollectCustomXmlMoveFromRangeStarts(this DocumentFormat.OpenXml.Wordprocessing.Paragraph element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart>();
    }
    public static IEnumerable<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd> CollectCustomXmlMoveToRangeEnds(this DocumentFormat.OpenXml.Wordprocessing.Paragraph element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd>();
    }
    public static IEnumerable<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart> CollectCustomXmlMoveToRangeStarts(this DocumentFormat.OpenXml.Wordprocessing.Paragraph element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart>();
    }
    public static IEnumerable<DocumentFormat.OpenXml.Wordprocessing.DeletedRun> CollectDeletedRuns(this DocumentFormat.OpenXml.Wordprocessing.Paragraph element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.DeletedRun>();
    }
    public static IEnumerable<DocumentFormat.OpenXml.Wordprocessing.BidirectionalEmbedding> CollectBidirectionalEmbeddings(this DocumentFormat.OpenXml.Wordprocessing.Paragraph element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.BidirectionalEmbedding>();
    }
    public static IEnumerable<DocumentFormat.OpenXml.Wordprocessing.SimpleField> CollectSimpleFields(this DocumentFormat.OpenXml.Wordprocessing.Paragraph element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.SimpleField>();
    }
    public static IEnumerable<DocumentFormat.OpenXml.Wordprocessing.Hyperlink> CollectHyperlinks(this DocumentFormat.OpenXml.Wordprocessing.Paragraph element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Hyperlink>();
    }
    public static IEnumerable<DocumentFormat.OpenXml.Wordprocessing.InsertedRun> CollectInsertedRuns(this DocumentFormat.OpenXml.Wordprocessing.Paragraph element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.InsertedRun>();
    }
    public static IEnumerable<DocumentFormat.OpenXml.Wordprocessing.MoveFromRun> CollectMoveFromRuns(this DocumentFormat.OpenXml.Wordprocessing.Paragraph element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.MoveFromRun>();
    }
    public static IEnumerable<DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd> CollectMoveFromRangeEnds(this DocumentFormat.OpenXml.Wordprocessing.Paragraph element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd>();
    }
    public static IEnumerable<DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart> CollectMoveFromRangeStarts(this DocumentFormat.OpenXml.Wordprocessing.Paragraph element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart>();
    }
    public static IEnumerable<DocumentFormat.OpenXml.Wordprocessing.MoveToRun> CollectMoveToRuns(this DocumentFormat.OpenXml.Wordprocessing.Paragraph element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.MoveToRun>();
    }
    public static IEnumerable<DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd> CollectMoveToRangeEnds(this DocumentFormat.OpenXml.Wordprocessing.Paragraph element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd>();
    }
    public static IEnumerable<DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart> CollectMoveToRangeStarts(this DocumentFormat.OpenXml.Wordprocessing.Paragraph element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart>();
    }
    public static IEnumerable<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties> CollectParagraphPropertiess(this DocumentFormat.OpenXml.Wordprocessing.Paragraph element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties>();
    }
    public static IEnumerable<DocumentFormat.OpenXml.Wordprocessing.PermEnd> CollectPermEnds(this DocumentFormat.OpenXml.Wordprocessing.Paragraph element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.PermEnd>();
    }
    public static IEnumerable<DocumentFormat.OpenXml.Wordprocessing.PermStart> CollectPermStarts(this DocumentFormat.OpenXml.Wordprocessing.Paragraph element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.PermStart>();
    }
    public static IEnumerable<DocumentFormat.OpenXml.Wordprocessing.ProofError> CollectProofErrors(this DocumentFormat.OpenXml.Wordprocessing.Paragraph element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ProofError>();
    }
    public static IEnumerable<DocumentFormat.OpenXml.Wordprocessing.Run> CollectRuns(this DocumentFormat.OpenXml.Wordprocessing.Paragraph element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Run>();
    }
    public static IEnumerable<DocumentFormat.OpenXml.Wordprocessing.SdtRun> CollectSdtRuns(this DocumentFormat.OpenXml.Wordprocessing.Paragraph element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.SdtRun>();
    }
    public static IEnumerable<DocumentFormat.OpenXml.Wordprocessing.SubDocumentReference> CollectSubDocumentReferences(this DocumentFormat.OpenXml.Wordprocessing.Paragraph element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.SubDocumentReference>();
    }
}

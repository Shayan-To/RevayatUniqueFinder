namespace RevayatUniqueFinder;

// Generated for type DocumentFormat.OpenXml.Wordprocessing.Document
static partial class OpenXmlExtensions
{
    public static ExtensionValue<DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Wordprocessing.DocumentConformance>> GetConformance(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Document> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.Document, DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Wordprocessing.DocumentConformance>>(new("Conformance", "conformance", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.DocumentBackground>> CollectDocumentBackgrounds(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Document> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Document, DocumentFormat.OpenXml.Wordprocessing.DocumentBackground>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Body>> CollectBodys(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Document> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Document, DocumentFormat.OpenXml.Wordprocessing.Body>();
    }
}

// Generated for type DocumentFormat.OpenXml.Wordprocessing.Body
static partial class OpenXmlExtensions
{
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.AltChunk>> CollectAltChunks(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Body> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Body, DocumentFormat.OpenXml.Wordprocessing.AltChunk>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd>> CollectBookmarkEnds(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Body> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Body, DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.BookmarkStart>> CollectBookmarkStarts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Body> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Body, DocumentFormat.OpenXml.Wordprocessing.BookmarkStart>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd>> CollectCommentRangeEnds(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Body> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Body, DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart>> CollectCommentRangeStarts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Body> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Body, DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ContentPart>> CollectContentParts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Body> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Body, DocumentFormat.OpenXml.Wordprocessing.ContentPart>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlBlock>> CollectCustomXmlBlocks(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Body> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Body, DocumentFormat.OpenXml.Wordprocessing.CustomXmlBlock>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd>> CollectCustomXmlDelRangeEnds(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Body> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Body, DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart>> CollectCustomXmlDelRangeStarts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Body> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Body, DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd>> CollectCustomXmlInsRangeEnds(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Body> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Body, DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart>> CollectCustomXmlInsRangeStarts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Body> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Body, DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd>> CollectCustomXmlMoveFromRangeEnds(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Body> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Body, DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart>> CollectCustomXmlMoveFromRangeStarts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Body> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Body, DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd>> CollectCustomXmlMoveToRangeEnds(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Body> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Body, DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart>> CollectCustomXmlMoveToRangeStarts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Body> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Body, DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.DeletedRun>> CollectDeletedRuns(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Body> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Body, DocumentFormat.OpenXml.Wordprocessing.DeletedRun>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.InsertedRun>> CollectInsertedRuns(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Body> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Body, DocumentFormat.OpenXml.Wordprocessing.InsertedRun>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.MoveFromRun>> CollectMoveFromRuns(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Body> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Body, DocumentFormat.OpenXml.Wordprocessing.MoveFromRun>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd>> CollectMoveFromRangeEnds(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Body> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Body, DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart>> CollectMoveFromRangeStarts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Body> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Body, DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.MoveToRun>> CollectMoveToRuns(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Body> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Body, DocumentFormat.OpenXml.Wordprocessing.MoveToRun>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd>> CollectMoveToRangeEnds(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Body> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Body, DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart>> CollectMoveToRangeStarts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Body> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Body, DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Paragraph>> CollectParagraphs(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Body> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Body, DocumentFormat.OpenXml.Wordprocessing.Paragraph>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.PermEnd>> CollectPermEnds(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Body> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Body, DocumentFormat.OpenXml.Wordprocessing.PermEnd>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.PermStart>> CollectPermStarts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Body> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Body, DocumentFormat.OpenXml.Wordprocessing.PermStart>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ProofError>> CollectProofErrors(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Body> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Body, DocumentFormat.OpenXml.Wordprocessing.ProofError>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.SdtBlock>> CollectSdtBlocks(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Body> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Body, DocumentFormat.OpenXml.Wordprocessing.SdtBlock>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.SectionProperties>> CollectSectionPropertiess(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Body> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Body, DocumentFormat.OpenXml.Wordprocessing.SectionProperties>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Table>> CollectTables(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Body> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Body, DocumentFormat.OpenXml.Wordprocessing.Table>();
    }
}

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

// Generated for type DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties
static partial class OpenXmlExtensions
{
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.AdjustRightIndent>> CollectAdjustRightIndents(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties, DocumentFormat.OpenXml.Wordprocessing.AdjustRightIndent>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.AutoSpaceDE>> CollectAutoSpaceDEs(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties, DocumentFormat.OpenXml.Wordprocessing.AutoSpaceDE>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.AutoSpaceDN>> CollectAutoSpaceDNs(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties, DocumentFormat.OpenXml.Wordprocessing.AutoSpaceDN>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.BiDi>> CollectBiDis(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties, DocumentFormat.OpenXml.Wordprocessing.BiDi>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ConditionalFormatStyle>> CollectConditionalFormatStyles(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties, DocumentFormat.OpenXml.Wordprocessing.ConditionalFormatStyle>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ContextualSpacing>> CollectContextualSpacings(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties, DocumentFormat.OpenXml.Wordprocessing.ContextualSpacing>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.DivId>> CollectDivIds(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties, DocumentFormat.OpenXml.Wordprocessing.DivId>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.FrameProperties>> CollectFramePropertiess(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties, DocumentFormat.OpenXml.Wordprocessing.FrameProperties>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Indentation>> CollectIndentations(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties, DocumentFormat.OpenXml.Wordprocessing.Indentation>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Justification>> CollectJustifications(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties, DocumentFormat.OpenXml.Wordprocessing.Justification>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.KeepLines>> CollectKeepLiness(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties, DocumentFormat.OpenXml.Wordprocessing.KeepLines>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.KeepNext>> CollectKeepNexts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties, DocumentFormat.OpenXml.Wordprocessing.KeepNext>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Kinsoku>> CollectKinsokus(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties, DocumentFormat.OpenXml.Wordprocessing.Kinsoku>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.MirrorIndents>> CollectMirrorIndentss(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties, DocumentFormat.OpenXml.Wordprocessing.MirrorIndents>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.NumberingProperties>> CollectNumberingPropertiess(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties, DocumentFormat.OpenXml.Wordprocessing.NumberingProperties>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.OutlineLevel>> CollectOutlineLevels(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties, DocumentFormat.OpenXml.Wordprocessing.OutlineLevel>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.OverflowPunctuation>> CollectOverflowPunctuations(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties, DocumentFormat.OpenXml.Wordprocessing.OverflowPunctuation>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphBorders>> CollectParagraphBorderss(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties, DocumentFormat.OpenXml.Wordprocessing.ParagraphBorders>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesChange>> CollectParagraphPropertiesChanges(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties, DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesChange>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphStyleId>> CollectParagraphStyleIds(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties, DocumentFormat.OpenXml.Wordprocessing.ParagraphStyleId>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.PageBreakBefore>> CollectPageBreakBefores(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties, DocumentFormat.OpenXml.Wordprocessing.PageBreakBefore>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties>> CollectParagraphMarkRunPropertiess(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties, DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.SectionProperties>> CollectSectionPropertiess(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties, DocumentFormat.OpenXml.Wordprocessing.SectionProperties>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Shading>> CollectShadings(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties, DocumentFormat.OpenXml.Wordprocessing.Shading>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.SnapToGrid>> CollectSnapToGrids(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties, DocumentFormat.OpenXml.Wordprocessing.SnapToGrid>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.SpacingBetweenLines>> CollectSpacingBetweenLiness(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties, DocumentFormat.OpenXml.Wordprocessing.SpacingBetweenLines>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.SuppressAutoHyphens>> CollectSuppressAutoHyphenss(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties, DocumentFormat.OpenXml.Wordprocessing.SuppressAutoHyphens>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.SuppressLineNumbers>> CollectSuppressLineNumberss(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties, DocumentFormat.OpenXml.Wordprocessing.SuppressLineNumbers>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.SuppressOverlap>> CollectSuppressOverlaps(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties, DocumentFormat.OpenXml.Wordprocessing.SuppressOverlap>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Tabs>> CollectTabss(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties, DocumentFormat.OpenXml.Wordprocessing.Tabs>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TextAlignment>> CollectTextAlignments(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties, DocumentFormat.OpenXml.Wordprocessing.TextAlignment>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TextDirection>> CollectTextDirections(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties, DocumentFormat.OpenXml.Wordprocessing.TextDirection>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TextBoxTightWrap>> CollectTextBoxTightWraps(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties, DocumentFormat.OpenXml.Wordprocessing.TextBoxTightWrap>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TopLinePunctuation>> CollectTopLinePunctuations(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties, DocumentFormat.OpenXml.Wordprocessing.TopLinePunctuation>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.WidowControl>> CollectWidowControls(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties, DocumentFormat.OpenXml.Wordprocessing.WidowControl>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.WordWrap>> CollectWordWraps(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties, DocumentFormat.OpenXml.Wordprocessing.WordWrap>();
    }
}

// Generated for type DocumentFormat.OpenXml.Wordprocessing.SpacingBetweenLines
static partial class OpenXmlExtensions
{
    public static ExtensionValue<DocumentFormat.OpenXml.StringValue> GetBefore(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.SpacingBetweenLines> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.SpacingBetweenLines, DocumentFormat.OpenXml.StringValue>(new("Before", "before", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.Int32Value> GetBeforeLines(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.SpacingBetweenLines> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.SpacingBetweenLines, DocumentFormat.OpenXml.Int32Value>(new("BeforeLines", "beforeLines", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.OnOffValue> GetBeforeAutoSpacing(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.SpacingBetweenLines> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.SpacingBetweenLines, DocumentFormat.OpenXml.OnOffValue>(new("BeforeAutoSpacing", "beforeAutospacing", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.StringValue> GetAfter(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.SpacingBetweenLines> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.SpacingBetweenLines, DocumentFormat.OpenXml.StringValue>(new("After", "after", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.Int32Value> GetAfterLines(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.SpacingBetweenLines> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.SpacingBetweenLines, DocumentFormat.OpenXml.Int32Value>(new("AfterLines", "afterLines", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.OnOffValue> GetAfterAutoSpacing(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.SpacingBetweenLines> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.SpacingBetweenLines, DocumentFormat.OpenXml.OnOffValue>(new("AfterAutoSpacing", "afterAutospacing", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.StringValue> GetLine(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.SpacingBetweenLines> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.SpacingBetweenLines, DocumentFormat.OpenXml.StringValue>(new("Line", "line", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Wordprocessing.LineSpacingRuleValues>> GetLineRule(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.SpacingBetweenLines> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.SpacingBetweenLines, DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Wordprocessing.LineSpacingRuleValues>>(new("LineRule", "lineRule", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
}

// Generated for type DocumentFormat.OpenXml.Wordprocessing.Justification
static partial class OpenXmlExtensions
{
    public static ExtensionValue<DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Wordprocessing.JustificationValues>> GetVal(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Justification> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.Justification, DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Wordprocessing.JustificationValues>>(new("Val", "val", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
}

// Generated for type DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties
static partial class OpenXmlExtensions
{
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Bold>> CollectBolds(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties, DocumentFormat.OpenXml.Wordprocessing.Bold>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.BoldComplexScript>> CollectBoldComplexScripts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties, DocumentFormat.OpenXml.Wordprocessing.BoldComplexScript>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Border>> CollectBorders(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties, DocumentFormat.OpenXml.Wordprocessing.Border>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Caps>> CollectCapss(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties, DocumentFormat.OpenXml.Wordprocessing.Caps>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Color>> CollectColors(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties, DocumentFormat.OpenXml.Wordprocessing.Color>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ComplexScript>> CollectComplexScripts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties, DocumentFormat.OpenXml.Wordprocessing.ComplexScript>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Deleted>> CollectDeleteds(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties, DocumentFormat.OpenXml.Wordprocessing.Deleted>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.DoubleStrike>> CollectDoubleStrikes(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties, DocumentFormat.OpenXml.Wordprocessing.DoubleStrike>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.EastAsianLayout>> CollectEastAsianLayouts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties, DocumentFormat.OpenXml.Wordprocessing.EastAsianLayout>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TextEffect>> CollectTextEffects(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties, DocumentFormat.OpenXml.Wordprocessing.TextEffect>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Emphasis>> CollectEmphasiss(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties, DocumentFormat.OpenXml.Wordprocessing.Emphasis>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Emboss>> CollectEmbosss(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties, DocumentFormat.OpenXml.Wordprocessing.Emboss>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.FitText>> CollectFitTexts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties, DocumentFormat.OpenXml.Wordprocessing.FitText>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Highlight>> CollectHighlights(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties, DocumentFormat.OpenXml.Wordprocessing.Highlight>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Italic>> CollectItalics(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties, DocumentFormat.OpenXml.Wordprocessing.Italic>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ItalicComplexScript>> CollectItalicComplexScripts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties, DocumentFormat.OpenXml.Wordprocessing.ItalicComplexScript>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Imprint>> CollectImprints(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties, DocumentFormat.OpenXml.Wordprocessing.Imprint>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Inserted>> CollectInserteds(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties, DocumentFormat.OpenXml.Wordprocessing.Inserted>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Kern>> CollectKerns(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties, DocumentFormat.OpenXml.Wordprocessing.Kern>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Languages>> CollectLanguagess(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties, DocumentFormat.OpenXml.Wordprocessing.Languages>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.MoveFrom>> CollectMoveFroms(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties, DocumentFormat.OpenXml.Wordprocessing.MoveFrom>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.MoveTo>> CollectMoveTos(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties, DocumentFormat.OpenXml.Wordprocessing.MoveTo>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.NoProof>> CollectNoProofs(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties, DocumentFormat.OpenXml.Wordprocessing.NoProof>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.OfficeMath>> CollectOfficeMaths(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties, DocumentFormat.OpenXml.Wordprocessing.OfficeMath>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Outline>> CollectOutlines(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties, DocumentFormat.OpenXml.Wordprocessing.Outline>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Position>> CollectPositions(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties, DocumentFormat.OpenXml.Wordprocessing.Position>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.RunFonts>> CollectRunFontss(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties, DocumentFormat.OpenXml.Wordprocessing.RunFonts>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunPropertiesChange>> CollectParagraphMarkRunPropertiesChanges(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties, DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunPropertiesChange>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.RunStyle>> CollectRunStyles(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties, DocumentFormat.OpenXml.Wordprocessing.RunStyle>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.RightToLeftText>> CollectRightToLeftTexts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties, DocumentFormat.OpenXml.Wordprocessing.RightToLeftText>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Shadow>> CollectShadows(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties, DocumentFormat.OpenXml.Wordprocessing.Shadow>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Shading>> CollectShadings(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties, DocumentFormat.OpenXml.Wordprocessing.Shading>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.SmallCaps>> CollectSmallCapss(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties, DocumentFormat.OpenXml.Wordprocessing.SmallCaps>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.SnapToGrid>> CollectSnapToGrids(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties, DocumentFormat.OpenXml.Wordprocessing.SnapToGrid>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Spacing>> CollectSpacings(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties, DocumentFormat.OpenXml.Wordprocessing.Spacing>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.SpecVanish>> CollectSpecVanishs(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties, DocumentFormat.OpenXml.Wordprocessing.SpecVanish>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Strike>> CollectStrikes(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties, DocumentFormat.OpenXml.Wordprocessing.Strike>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.FontSize>> CollectFontSizes(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties, DocumentFormat.OpenXml.Wordprocessing.FontSize>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.FontSizeComplexScript>> CollectFontSizeComplexScripts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties, DocumentFormat.OpenXml.Wordprocessing.FontSizeComplexScript>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Underline>> CollectUnderlines(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties, DocumentFormat.OpenXml.Wordprocessing.Underline>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Vanish>> CollectVanishs(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties, DocumentFormat.OpenXml.Wordprocessing.Vanish>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.VerticalTextAlignment>> CollectVerticalTextAlignments(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties, DocumentFormat.OpenXml.Wordprocessing.VerticalTextAlignment>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CharacterScale>> CollectCharacterScales(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties, DocumentFormat.OpenXml.Wordprocessing.CharacterScale>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.WebHidden>> CollectWebHiddens(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties, DocumentFormat.OpenXml.Wordprocessing.WebHidden>();
    }
}

// Generated for type DocumentFormat.OpenXml.Wordprocessing.RunFonts
static partial class OpenXmlExtensions
{
    public static ExtensionValue<DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Wordprocessing.FontTypeHintValues>> GetHint(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.RunFonts> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.RunFonts, DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Wordprocessing.FontTypeHintValues>>(new("Hint", "hint", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.StringValue> GetAscii(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.RunFonts> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.RunFonts, DocumentFormat.OpenXml.StringValue>(new("Ascii", "ascii", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.StringValue> GetHighAnsi(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.RunFonts> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.RunFonts, DocumentFormat.OpenXml.StringValue>(new("HighAnsi", "hAnsi", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.StringValue> GetEastAsia(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.RunFonts> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.RunFonts, DocumentFormat.OpenXml.StringValue>(new("EastAsia", "eastAsia", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.StringValue> GetComplexScript(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.RunFonts> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.RunFonts, DocumentFormat.OpenXml.StringValue>(new("ComplexScript", "cs", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues>> GetAsciiTheme(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.RunFonts> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.RunFonts, DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues>>(new("AsciiTheme", "asciiTheme", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues>> GetHighAnsiTheme(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.RunFonts> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.RunFonts, DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues>>(new("HighAnsiTheme", "hAnsiTheme", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues>> GetEastAsiaTheme(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.RunFonts> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.RunFonts, DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues>>(new("EastAsiaTheme", "eastAsiaTheme", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues>> GetComplexScriptTheme(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.RunFonts> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.RunFonts, DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues>>(new("ComplexScriptTheme", "cstheme", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
}

// Generated for type DocumentFormat.OpenXml.Wordprocessing.Color
static partial class OpenXmlExtensions
{
    public static ExtensionValue<DocumentFormat.OpenXml.StringValue> GetVal(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Color> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.Color, DocumentFormat.OpenXml.StringValue>(new("Val", "val", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues>> GetThemeColor(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Color> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.Color, DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues>>(new("ThemeColor", "themeColor", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.StringValue> GetThemeTint(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Color> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.Color, DocumentFormat.OpenXml.StringValue>(new("ThemeTint", "themeTint", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.StringValue> GetThemeShade(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Color> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.Color, DocumentFormat.OpenXml.StringValue>(new("ThemeShade", "themeShade", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
}

// Generated for type DocumentFormat.OpenXml.Wordprocessing.FontSize
static partial class OpenXmlExtensions
{
    public static ExtensionValue<DocumentFormat.OpenXml.StringValue> GetVal(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.FontSize> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.FontSize, DocumentFormat.OpenXml.StringValue>(new("Val", "val", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
}

// Generated for type DocumentFormat.OpenXml.Wordprocessing.FontSizeComplexScript
static partial class OpenXmlExtensions
{
    public static ExtensionValue<DocumentFormat.OpenXml.StringValue> GetVal(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.FontSizeComplexScript> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.FontSizeComplexScript, DocumentFormat.OpenXml.StringValue>(new("Val", "val", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
}

// Generated for type DocumentFormat.OpenXml.Wordprocessing.RightToLeftText
static partial class OpenXmlExtensions
{
    public static ExtensionValue<DocumentFormat.OpenXml.OnOffValue> GetVal(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.RightToLeftText> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.RightToLeftText, DocumentFormat.OpenXml.OnOffValue>(new("Val", "val", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
}

// Generated for type DocumentFormat.OpenXml.Wordprocessing.BookmarkStart
static partial class OpenXmlExtensions
{
    public static ExtensionValue<DocumentFormat.OpenXml.StringValue> GetName(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.BookmarkStart> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.BookmarkStart, DocumentFormat.OpenXml.StringValue>(new("Name", "name", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.Int32Value> GetColumnFirst(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.BookmarkStart> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.BookmarkStart, DocumentFormat.OpenXml.Int32Value>(new("ColumnFirst", "colFirst", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.Int32Value> GetColumnLast(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.BookmarkStart> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.BookmarkStart, DocumentFormat.OpenXml.Int32Value>(new("ColumnLast", "colLast", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Wordprocessing.DisplacedByCustomXmlValues>> GetDisplacedByCustomXml(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.BookmarkStart> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.BookmarkStart, DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Wordprocessing.DisplacedByCustomXmlValues>>(new("DisplacedByCustomXml", "displacedByCustomXml", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.StringValue> GetId(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.BookmarkStart> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.BookmarkStart, DocumentFormat.OpenXml.StringValue>(new("Id", "id", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
}

// Generated for type DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd
static partial class OpenXmlExtensions
{
    public static ExtensionValue<DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Wordprocessing.DisplacedByCustomXmlValues>> GetDisplacedByCustomXml(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd, DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Wordprocessing.DisplacedByCustomXmlValues>>(new("DisplacedByCustomXml", "displacedByCustomXml", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.StringValue> GetId(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd, DocumentFormat.OpenXml.StringValue>(new("Id", "id", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
}

// Generated for type DocumentFormat.OpenXml.Wordprocessing.Run
static partial class OpenXmlExtensions
{
    public static ExtensionValue<DocumentFormat.OpenXml.HexBinaryValue> GetRsidRunProperties(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Run> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.Run, DocumentFormat.OpenXml.HexBinaryValue>(new("RsidRunProperties", "rsidRPr", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.HexBinaryValue> GetRsidRunDeletion(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Run> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.Run, DocumentFormat.OpenXml.HexBinaryValue>(new("RsidRunDeletion", "rsidDel", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.HexBinaryValue> GetRsidRunAddition(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Run> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.Run, DocumentFormat.OpenXml.HexBinaryValue>(new("RsidRunAddition", "rsidR", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.AnnotationReferenceMark>> CollectAnnotationReferenceMarks(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Run> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Run, DocumentFormat.OpenXml.Wordprocessing.AnnotationReferenceMark>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Break>> CollectBreaks(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Run> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Run, DocumentFormat.OpenXml.Wordprocessing.Break>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CommentReference>> CollectCommentReferences(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Run> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Run, DocumentFormat.OpenXml.Wordprocessing.CommentReference>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ContinuationSeparatorMark>> CollectContinuationSeparatorMarks(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Run> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Run, DocumentFormat.OpenXml.Wordprocessing.ContinuationSeparatorMark>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CarriageReturn>> CollectCarriageReturns(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Run> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Run, DocumentFormat.OpenXml.Wordprocessing.CarriageReturn>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.DayLong>> CollectDayLongs(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Run> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Run, DocumentFormat.OpenXml.Wordprocessing.DayLong>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.DayShort>> CollectDayShorts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Run> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Run, DocumentFormat.OpenXml.Wordprocessing.DayShort>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.DeletedFieldCode>> CollectDeletedFieldCodes(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Run> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Run, DocumentFormat.OpenXml.Wordprocessing.DeletedFieldCode>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.DeletedText>> CollectDeletedTexts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Run> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Run, DocumentFormat.OpenXml.Wordprocessing.DeletedText>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Drawing>> CollectDrawings(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Run> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Run, DocumentFormat.OpenXml.Wordprocessing.Drawing>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.EndnoteReferenceMark>> CollectEndnoteReferenceMarks(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Run> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Run, DocumentFormat.OpenXml.Wordprocessing.EndnoteReferenceMark>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.EndnoteReference>> CollectEndnoteReferences(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Run> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Run, DocumentFormat.OpenXml.Wordprocessing.EndnoteReference>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.FieldChar>> CollectFieldChars(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Run> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Run, DocumentFormat.OpenXml.Wordprocessing.FieldChar>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.FootnoteReferenceMark>> CollectFootnoteReferenceMarks(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Run> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Run, DocumentFormat.OpenXml.Wordprocessing.FootnoteReferenceMark>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.FootnoteReference>> CollectFootnoteReferences(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Run> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Run, DocumentFormat.OpenXml.Wordprocessing.FootnoteReference>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.FieldCode>> CollectFieldCodes(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Run> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Run, DocumentFormat.OpenXml.Wordprocessing.FieldCode>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.LastRenderedPageBreak>> CollectLastRenderedPageBreaks(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Run> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Run, DocumentFormat.OpenXml.Wordprocessing.LastRenderedPageBreak>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.MonthLong>> CollectMonthLongs(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Run> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Run, DocumentFormat.OpenXml.Wordprocessing.MonthLong>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.MonthShort>> CollectMonthShorts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Run> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Run, DocumentFormat.OpenXml.Wordprocessing.MonthShort>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.NoBreakHyphen>> CollectNoBreakHyphens(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Run> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Run, DocumentFormat.OpenXml.Wordprocessing.NoBreakHyphen>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject>> CollectEmbeddedObjects(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Run> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Run, DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.PageNumber>> CollectPageNumbers(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Run> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Run, DocumentFormat.OpenXml.Wordprocessing.PageNumber>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Picture>> CollectPictures(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Run> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Run, DocumentFormat.OpenXml.Wordprocessing.Picture>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.PositionalTab>> CollectPositionalTabs(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Run> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Run, DocumentFormat.OpenXml.Wordprocessing.PositionalTab>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.RunProperties>> CollectRunPropertiess(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Run> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Run, DocumentFormat.OpenXml.Wordprocessing.RunProperties>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Ruby>> CollectRubys(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Run> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Run, DocumentFormat.OpenXml.Wordprocessing.Ruby>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.SeparatorMark>> CollectSeparatorMarks(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Run> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Run, DocumentFormat.OpenXml.Wordprocessing.SeparatorMark>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.SoftHyphen>> CollectSoftHyphens(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Run> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Run, DocumentFormat.OpenXml.Wordprocessing.SoftHyphen>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.SymbolChar>> CollectSymbolChars(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Run> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Run, DocumentFormat.OpenXml.Wordprocessing.SymbolChar>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Text>> CollectTexts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Run> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Run, DocumentFormat.OpenXml.Wordprocessing.Text>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TabChar>> CollectTabChars(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Run> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Run, DocumentFormat.OpenXml.Wordprocessing.TabChar>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.YearLong>> CollectYearLongs(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Run> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Run, DocumentFormat.OpenXml.Wordprocessing.YearLong>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.YearShort>> CollectYearShorts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Run> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Run, DocumentFormat.OpenXml.Wordprocessing.YearShort>();
    }
}

// Generated for type DocumentFormat.OpenXml.Wordprocessing.RunProperties
static partial class OpenXmlExtensions
{
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Bold>> CollectBolds(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.RunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.RunProperties, DocumentFormat.OpenXml.Wordprocessing.Bold>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.BoldComplexScript>> CollectBoldComplexScripts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.RunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.RunProperties, DocumentFormat.OpenXml.Wordprocessing.BoldComplexScript>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Border>> CollectBorders(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.RunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.RunProperties, DocumentFormat.OpenXml.Wordprocessing.Border>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Caps>> CollectCapss(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.RunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.RunProperties, DocumentFormat.OpenXml.Wordprocessing.Caps>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Color>> CollectColors(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.RunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.RunProperties, DocumentFormat.OpenXml.Wordprocessing.Color>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ComplexScript>> CollectComplexScripts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.RunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.RunProperties, DocumentFormat.OpenXml.Wordprocessing.ComplexScript>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.DoubleStrike>> CollectDoubleStrikes(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.RunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.RunProperties, DocumentFormat.OpenXml.Wordprocessing.DoubleStrike>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.EastAsianLayout>> CollectEastAsianLayouts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.RunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.RunProperties, DocumentFormat.OpenXml.Wordprocessing.EastAsianLayout>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TextEffect>> CollectTextEffects(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.RunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.RunProperties, DocumentFormat.OpenXml.Wordprocessing.TextEffect>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Emphasis>> CollectEmphasiss(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.RunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.RunProperties, DocumentFormat.OpenXml.Wordprocessing.Emphasis>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Emboss>> CollectEmbosss(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.RunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.RunProperties, DocumentFormat.OpenXml.Wordprocessing.Emboss>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.FitText>> CollectFitTexts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.RunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.RunProperties, DocumentFormat.OpenXml.Wordprocessing.FitText>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Highlight>> CollectHighlights(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.RunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.RunProperties, DocumentFormat.OpenXml.Wordprocessing.Highlight>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Italic>> CollectItalics(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.RunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.RunProperties, DocumentFormat.OpenXml.Wordprocessing.Italic>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ItalicComplexScript>> CollectItalicComplexScripts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.RunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.RunProperties, DocumentFormat.OpenXml.Wordprocessing.ItalicComplexScript>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Imprint>> CollectImprints(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.RunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.RunProperties, DocumentFormat.OpenXml.Wordprocessing.Imprint>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Kern>> CollectKerns(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.RunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.RunProperties, DocumentFormat.OpenXml.Wordprocessing.Kern>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Languages>> CollectLanguagess(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.RunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.RunProperties, DocumentFormat.OpenXml.Wordprocessing.Languages>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.NoProof>> CollectNoProofs(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.RunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.RunProperties, DocumentFormat.OpenXml.Wordprocessing.NoProof>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Outline>> CollectOutlines(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.RunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.RunProperties, DocumentFormat.OpenXml.Wordprocessing.Outline>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Position>> CollectPositions(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.RunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.RunProperties, DocumentFormat.OpenXml.Wordprocessing.Position>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.RunFonts>> CollectRunFontss(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.RunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.RunProperties, DocumentFormat.OpenXml.Wordprocessing.RunFonts>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.RunPropertiesChange>> CollectRunPropertiesChanges(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.RunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.RunProperties, DocumentFormat.OpenXml.Wordprocessing.RunPropertiesChange>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.RunStyle>> CollectRunStyles(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.RunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.RunProperties, DocumentFormat.OpenXml.Wordprocessing.RunStyle>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.RightToLeftText>> CollectRightToLeftTexts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.RunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.RunProperties, DocumentFormat.OpenXml.Wordprocessing.RightToLeftText>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Shadow>> CollectShadows(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.RunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.RunProperties, DocumentFormat.OpenXml.Wordprocessing.Shadow>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Shading>> CollectShadings(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.RunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.RunProperties, DocumentFormat.OpenXml.Wordprocessing.Shading>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.SmallCaps>> CollectSmallCapss(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.RunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.RunProperties, DocumentFormat.OpenXml.Wordprocessing.SmallCaps>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.SnapToGrid>> CollectSnapToGrids(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.RunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.RunProperties, DocumentFormat.OpenXml.Wordprocessing.SnapToGrid>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Spacing>> CollectSpacings(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.RunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.RunProperties, DocumentFormat.OpenXml.Wordprocessing.Spacing>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.SpecVanish>> CollectSpecVanishs(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.RunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.RunProperties, DocumentFormat.OpenXml.Wordprocessing.SpecVanish>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Strike>> CollectStrikes(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.RunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.RunProperties, DocumentFormat.OpenXml.Wordprocessing.Strike>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.FontSize>> CollectFontSizes(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.RunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.RunProperties, DocumentFormat.OpenXml.Wordprocessing.FontSize>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.FontSizeComplexScript>> CollectFontSizeComplexScripts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.RunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.RunProperties, DocumentFormat.OpenXml.Wordprocessing.FontSizeComplexScript>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Underline>> CollectUnderlines(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.RunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.RunProperties, DocumentFormat.OpenXml.Wordprocessing.Underline>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Vanish>> CollectVanishs(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.RunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.RunProperties, DocumentFormat.OpenXml.Wordprocessing.Vanish>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.VerticalTextAlignment>> CollectVerticalTextAlignments(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.RunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.RunProperties, DocumentFormat.OpenXml.Wordprocessing.VerticalTextAlignment>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CharacterScale>> CollectCharacterScales(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.RunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.RunProperties, DocumentFormat.OpenXml.Wordprocessing.CharacterScale>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.WebHidden>> CollectWebHiddens(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.RunProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.RunProperties, DocumentFormat.OpenXml.Wordprocessing.WebHidden>();
    }
}

// Generated for type DocumentFormat.OpenXml.Wordprocessing.Text
static partial class OpenXmlExtensions
{
    public static ExtensionValue<DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.SpaceProcessingModeValues>> GetSpace(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Text> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.Text, DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.SpaceProcessingModeValues>>(new("Space", "space", "http://www.w3.org/XML/1998/namespace", "xml"));
    }
}

// Generated for type DocumentFormat.OpenXml.Wordprocessing.Break
static partial class OpenXmlExtensions
{
    public static ExtensionValue<DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Wordprocessing.BreakValues>> GetType(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Break> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.Break, DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Wordprocessing.BreakValues>>(new("Type", "type", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Wordprocessing.BreakTextRestartLocationValues>> GetClear(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Break> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.Break, DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Wordprocessing.BreakTextRestartLocationValues>>(new("Clear", "clear", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
}

// Generated for type DocumentFormat.OpenXml.Wordprocessing.LastRenderedPageBreak
static partial class OpenXmlExtensions
{
}

// Generated for type DocumentFormat.OpenXml.Wordprocessing.Table
static partial class OpenXmlExtensions
{
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd>> CollectBookmarkEnds(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Table> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Table, DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.BookmarkStart>> CollectBookmarkStarts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Table> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Table, DocumentFormat.OpenXml.Wordprocessing.BookmarkStart>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd>> CollectCommentRangeEnds(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Table> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Table, DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart>> CollectCommentRangeStarts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Table> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Table, DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ContentPart>> CollectContentParts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Table> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Table, DocumentFormat.OpenXml.Wordprocessing.ContentPart>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlRow>> CollectCustomXmlRows(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Table> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Table, DocumentFormat.OpenXml.Wordprocessing.CustomXmlRow>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd>> CollectCustomXmlDelRangeEnds(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Table> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Table, DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart>> CollectCustomXmlDelRangeStarts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Table> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Table, DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd>> CollectCustomXmlInsRangeEnds(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Table> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Table, DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart>> CollectCustomXmlInsRangeStarts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Table> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Table, DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd>> CollectCustomXmlMoveFromRangeEnds(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Table> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Table, DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart>> CollectCustomXmlMoveFromRangeStarts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Table> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Table, DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd>> CollectCustomXmlMoveToRangeEnds(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Table> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Table, DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart>> CollectCustomXmlMoveToRangeStarts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Table> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Table, DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.DeletedRun>> CollectDeletedRuns(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Table> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Table, DocumentFormat.OpenXml.Wordprocessing.DeletedRun>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.InsertedRun>> CollectInsertedRuns(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Table> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Table, DocumentFormat.OpenXml.Wordprocessing.InsertedRun>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.MoveFromRun>> CollectMoveFromRuns(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Table> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Table, DocumentFormat.OpenXml.Wordprocessing.MoveFromRun>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd>> CollectMoveFromRangeEnds(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Table> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Table, DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart>> CollectMoveFromRangeStarts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Table> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Table, DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.MoveToRun>> CollectMoveToRuns(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Table> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Table, DocumentFormat.OpenXml.Wordprocessing.MoveToRun>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd>> CollectMoveToRangeEnds(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Table> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Table, DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart>> CollectMoveToRangeStarts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Table> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Table, DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.PermEnd>> CollectPermEnds(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Table> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Table, DocumentFormat.OpenXml.Wordprocessing.PermEnd>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.PermStart>> CollectPermStarts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Table> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Table, DocumentFormat.OpenXml.Wordprocessing.PermStart>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ProofError>> CollectProofErrors(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Table> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Table, DocumentFormat.OpenXml.Wordprocessing.ProofError>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.SdtRow>> CollectSdtRows(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Table> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Table, DocumentFormat.OpenXml.Wordprocessing.SdtRow>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableGrid>> CollectTableGrids(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Table> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Table, DocumentFormat.OpenXml.Wordprocessing.TableGrid>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableProperties>> CollectTablePropertiess(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Table> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Table, DocumentFormat.OpenXml.Wordprocessing.TableProperties>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableRow>> CollectTableRows(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Table> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Table, DocumentFormat.OpenXml.Wordprocessing.TableRow>();
    }
}

// Generated for type DocumentFormat.OpenXml.Wordprocessing.TableProperties
static partial class OpenXmlExtensions
{
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.BiDiVisual>> CollectBiDiVisuals(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableProperties, DocumentFormat.OpenXml.Wordprocessing.BiDiVisual>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableJustification>> CollectTableJustifications(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableProperties, DocumentFormat.OpenXml.Wordprocessing.TableJustification>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Shading>> CollectShadings(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableProperties, DocumentFormat.OpenXml.Wordprocessing.Shading>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableBorders>> CollectTableBorderss(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableProperties, DocumentFormat.OpenXml.Wordprocessing.TableBorders>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCaption>> CollectTableCaptions(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableProperties, DocumentFormat.OpenXml.Wordprocessing.TableCaption>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCellMarginDefault>> CollectTableCellMarginDefaults(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableProperties, DocumentFormat.OpenXml.Wordprocessing.TableCellMarginDefault>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCellSpacing>> CollectTableCellSpacings(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableProperties, DocumentFormat.OpenXml.Wordprocessing.TableCellSpacing>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableDescription>> CollectTableDescriptions(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableProperties, DocumentFormat.OpenXml.Wordprocessing.TableDescription>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableIndentation>> CollectTableIndentations(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableProperties, DocumentFormat.OpenXml.Wordprocessing.TableIndentation>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableLayout>> CollectTableLayouts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableProperties, DocumentFormat.OpenXml.Wordprocessing.TableLayout>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableLook>> CollectTableLooks(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableProperties, DocumentFormat.OpenXml.Wordprocessing.TableLook>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableOverlap>> CollectTableOverlaps(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableProperties, DocumentFormat.OpenXml.Wordprocessing.TableOverlap>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TablePropertiesChange>> CollectTablePropertiesChanges(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableProperties, DocumentFormat.OpenXml.Wordprocessing.TablePropertiesChange>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableStyle>> CollectTableStyles(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableProperties, DocumentFormat.OpenXml.Wordprocessing.TableStyle>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableWidth>> CollectTableWidths(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableProperties, DocumentFormat.OpenXml.Wordprocessing.TableWidth>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties>> CollectTablePositionPropertiess(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableProperties, DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties>();
    }
}

// Generated for type DocumentFormat.OpenXml.Wordprocessing.BiDiVisual
static partial class OpenXmlExtensions
{
    public static ExtensionValue<DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues>> GetVal(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.BiDiVisual> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.BiDiVisual, DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues>>(new("Val", "val", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
}

// Generated for type DocumentFormat.OpenXml.Wordprocessing.TableWidth
static partial class OpenXmlExtensions
{
    public static ExtensionValue<DocumentFormat.OpenXml.StringValue> GetWidth(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableWidth> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.TableWidth, DocumentFormat.OpenXml.StringValue>(new("Width", "w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Wordprocessing.TableWidthUnitValues>> GetType(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableWidth> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.TableWidth, DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Wordprocessing.TableWidthUnitValues>>(new("Type", "type", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
}

// Generated for type DocumentFormat.OpenXml.Wordprocessing.TableJustification
static partial class OpenXmlExtensions
{
    public static ExtensionValue<DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues>> GetVal(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableJustification> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.TableJustification, DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues>>(new("Val", "val", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
}

// Generated for type DocumentFormat.OpenXml.Wordprocessing.TableCellSpacing
static partial class OpenXmlExtensions
{
    public static ExtensionValue<DocumentFormat.OpenXml.StringValue> GetWidth(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCellSpacing> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.TableCellSpacing, DocumentFormat.OpenXml.StringValue>(new("Width", "w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Wordprocessing.TableWidthUnitValues>> GetType(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCellSpacing> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.TableCellSpacing, DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Wordprocessing.TableWidthUnitValues>>(new("Type", "type", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
}

// Generated for type DocumentFormat.OpenXml.Wordprocessing.TableCellMarginDefault
static partial class OpenXmlExtensions
{
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.BottomMargin>> CollectBottomMargins(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCellMarginDefault> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableCellMarginDefault, DocumentFormat.OpenXml.Wordprocessing.BottomMargin>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.EndMargin>> CollectEndMargins(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCellMarginDefault> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableCellMarginDefault, DocumentFormat.OpenXml.Wordprocessing.EndMargin>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCellLeftMargin>> CollectTableCellLeftMargins(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCellMarginDefault> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableCellMarginDefault, DocumentFormat.OpenXml.Wordprocessing.TableCellLeftMargin>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCellRightMargin>> CollectTableCellRightMargins(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCellMarginDefault> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableCellMarginDefault, DocumentFormat.OpenXml.Wordprocessing.TableCellRightMargin>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.StartMargin>> CollectStartMargins(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCellMarginDefault> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableCellMarginDefault, DocumentFormat.OpenXml.Wordprocessing.StartMargin>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TopMargin>> CollectTopMargins(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCellMarginDefault> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableCellMarginDefault, DocumentFormat.OpenXml.Wordprocessing.TopMargin>();
    }
}

// Generated for type DocumentFormat.OpenXml.Wordprocessing.TopMargin
static partial class OpenXmlExtensions
{
    public static ExtensionValue<DocumentFormat.OpenXml.StringValue> GetWidth(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TopMargin> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.TopMargin, DocumentFormat.OpenXml.StringValue>(new("Width", "w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Wordprocessing.TableWidthUnitValues>> GetType(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TopMargin> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.TopMargin, DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Wordprocessing.TableWidthUnitValues>>(new("Type", "type", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
}

// Generated for type DocumentFormat.OpenXml.Wordprocessing.TableCellLeftMargin
static partial class OpenXmlExtensions
{
    public static ExtensionValue<DocumentFormat.OpenXml.Int16Value> GetWidth(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCellLeftMargin> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.TableCellLeftMargin, DocumentFormat.OpenXml.Int16Value>(new("Width", "w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Wordprocessing.TableWidthValues>> GetType(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCellLeftMargin> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.TableCellLeftMargin, DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Wordprocessing.TableWidthValues>>(new("Type", "type", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
}

// Generated for type DocumentFormat.OpenXml.Wordprocessing.BottomMargin
static partial class OpenXmlExtensions
{
    public static ExtensionValue<DocumentFormat.OpenXml.StringValue> GetWidth(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.BottomMargin> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.BottomMargin, DocumentFormat.OpenXml.StringValue>(new("Width", "w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Wordprocessing.TableWidthUnitValues>> GetType(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.BottomMargin> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.BottomMargin, DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Wordprocessing.TableWidthUnitValues>>(new("Type", "type", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
}

// Generated for type DocumentFormat.OpenXml.Wordprocessing.TableCellRightMargin
static partial class OpenXmlExtensions
{
    public static ExtensionValue<DocumentFormat.OpenXml.Int16Value> GetWidth(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCellRightMargin> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.TableCellRightMargin, DocumentFormat.OpenXml.Int16Value>(new("Width", "w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Wordprocessing.TableWidthValues>> GetType(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCellRightMargin> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.TableCellRightMargin, DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Wordprocessing.TableWidthValues>>(new("Type", "type", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
}

// Generated for type DocumentFormat.OpenXml.Wordprocessing.TableLook
static partial class OpenXmlExtensions
{
    public static ExtensionValue<DocumentFormat.OpenXml.HexBinaryValue> GetVal(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableLook> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.TableLook, DocumentFormat.OpenXml.HexBinaryValue>(new("Val", "val", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.OnOffValue> GetFirstRow(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableLook> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.TableLook, DocumentFormat.OpenXml.OnOffValue>(new("FirstRow", "firstRow", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.OnOffValue> GetLastRow(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableLook> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.TableLook, DocumentFormat.OpenXml.OnOffValue>(new("LastRow", "lastRow", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.OnOffValue> GetFirstColumn(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableLook> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.TableLook, DocumentFormat.OpenXml.OnOffValue>(new("FirstColumn", "firstColumn", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.OnOffValue> GetLastColumn(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableLook> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.TableLook, DocumentFormat.OpenXml.OnOffValue>(new("LastColumn", "lastColumn", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.OnOffValue> GetNoHorizontalBand(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableLook> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.TableLook, DocumentFormat.OpenXml.OnOffValue>(new("NoHorizontalBand", "noHBand", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.OnOffValue> GetNoVerticalBand(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableLook> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.TableLook, DocumentFormat.OpenXml.OnOffValue>(new("NoVerticalBand", "noVBand", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
}

// Generated for type DocumentFormat.OpenXml.Wordprocessing.TableGrid
static partial class OpenXmlExtensions
{
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.GridColumn>> CollectGridColumns(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableGrid> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableGrid, DocumentFormat.OpenXml.Wordprocessing.GridColumn>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableGridChange>> CollectTableGridChanges(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableGrid> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableGrid, DocumentFormat.OpenXml.Wordprocessing.TableGridChange>();
    }
}

// Generated for type DocumentFormat.OpenXml.Wordprocessing.GridColumn
static partial class OpenXmlExtensions
{
    public static ExtensionValue<DocumentFormat.OpenXml.StringValue> GetWidth(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.GridColumn> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.GridColumn, DocumentFormat.OpenXml.StringValue>(new("Width", "w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
}

// Generated for type DocumentFormat.OpenXml.Wordprocessing.TableRow
static partial class OpenXmlExtensions
{
    public static ExtensionValue<DocumentFormat.OpenXml.HexBinaryValue> GetRsidTableRowMarkRevision(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableRow> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.TableRow, DocumentFormat.OpenXml.HexBinaryValue>(new("RsidTableRowMarkRevision", "rsidRPr", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.HexBinaryValue> GetRsidTableRowAddition(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableRow> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.TableRow, DocumentFormat.OpenXml.HexBinaryValue>(new("RsidTableRowAddition", "rsidR", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.HexBinaryValue> GetRsidTableRowDeletion(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableRow> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.TableRow, DocumentFormat.OpenXml.HexBinaryValue>(new("RsidTableRowDeletion", "rsidDel", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.HexBinaryValue> GetRsidTableRowProperties(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableRow> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.TableRow, DocumentFormat.OpenXml.HexBinaryValue>(new("RsidTableRowProperties", "rsidTr", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.HexBinaryValue> GetParagraphId(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableRow> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.TableRow, DocumentFormat.OpenXml.HexBinaryValue>(new("ParagraphId", "paraId", "http://schemas.microsoft.com/office/word/2010/wordml", "w14"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.HexBinaryValue> GetTextId(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableRow> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.TableRow, DocumentFormat.OpenXml.HexBinaryValue>(new("TextId", "textId", "http://schemas.microsoft.com/office/word/2010/wordml", "w14"));
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd>> CollectBookmarkEnds(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableRow> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableRow, DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.BookmarkStart>> CollectBookmarkStarts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableRow> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableRow, DocumentFormat.OpenXml.Wordprocessing.BookmarkStart>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd>> CollectCommentRangeEnds(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableRow> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableRow, DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart>> CollectCommentRangeStarts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableRow> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableRow, DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ContentPart>> CollectContentParts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableRow> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableRow, DocumentFormat.OpenXml.Wordprocessing.ContentPart>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlCell>> CollectCustomXmlCells(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableRow> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableRow, DocumentFormat.OpenXml.Wordprocessing.CustomXmlCell>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd>> CollectCustomXmlDelRangeEnds(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableRow> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableRow, DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart>> CollectCustomXmlDelRangeStarts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableRow> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableRow, DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd>> CollectCustomXmlInsRangeEnds(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableRow> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableRow, DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart>> CollectCustomXmlInsRangeStarts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableRow> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableRow, DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd>> CollectCustomXmlMoveFromRangeEnds(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableRow> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableRow, DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart>> CollectCustomXmlMoveFromRangeStarts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableRow> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableRow, DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd>> CollectCustomXmlMoveToRangeEnds(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableRow> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableRow, DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart>> CollectCustomXmlMoveToRangeStarts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableRow> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableRow, DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.DeletedRun>> CollectDeletedRuns(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableRow> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableRow, DocumentFormat.OpenXml.Wordprocessing.DeletedRun>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.InsertedRun>> CollectInsertedRuns(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableRow> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableRow, DocumentFormat.OpenXml.Wordprocessing.InsertedRun>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.MoveFromRun>> CollectMoveFromRuns(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableRow> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableRow, DocumentFormat.OpenXml.Wordprocessing.MoveFromRun>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd>> CollectMoveFromRangeEnds(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableRow> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableRow, DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart>> CollectMoveFromRangeStarts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableRow> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableRow, DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.MoveToRun>> CollectMoveToRuns(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableRow> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableRow, DocumentFormat.OpenXml.Wordprocessing.MoveToRun>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd>> CollectMoveToRangeEnds(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableRow> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableRow, DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart>> CollectMoveToRangeStarts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableRow> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableRow, DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.PermEnd>> CollectPermEnds(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableRow> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableRow, DocumentFormat.OpenXml.Wordprocessing.PermEnd>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.PermStart>> CollectPermStarts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableRow> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableRow, DocumentFormat.OpenXml.Wordprocessing.PermStart>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ProofError>> CollectProofErrors(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableRow> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableRow, DocumentFormat.OpenXml.Wordprocessing.ProofError>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.SdtCell>> CollectSdtCells(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableRow> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableRow, DocumentFormat.OpenXml.Wordprocessing.SdtCell>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TablePropertyExceptions>> CollectTablePropertyExceptionss(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableRow> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableRow, DocumentFormat.OpenXml.Wordprocessing.TablePropertyExceptions>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCell>> CollectTableCells(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableRow> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableRow, DocumentFormat.OpenXml.Wordprocessing.TableCell>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableRowProperties>> CollectTableRowPropertiess(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableRow> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableRow, DocumentFormat.OpenXml.Wordprocessing.TableRowProperties>();
    }
}

// Generated for type DocumentFormat.OpenXml.Wordprocessing.TableRowProperties
static partial class OpenXmlExtensions
{
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CantSplit>> CollectCantSplits(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableRowProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableRowProperties, DocumentFormat.OpenXml.Wordprocessing.CantSplit>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ConditionalFormatStyle>> CollectConditionalFormatStyles(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableRowProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableRowProperties, DocumentFormat.OpenXml.Wordprocessing.ConditionalFormatStyle>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Deleted>> CollectDeleteds(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableRowProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableRowProperties, DocumentFormat.OpenXml.Wordprocessing.Deleted>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.DivId>> CollectDivIds(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableRowProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableRowProperties, DocumentFormat.OpenXml.Wordprocessing.DivId>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.GridAfter>> CollectGridAfters(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableRowProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableRowProperties, DocumentFormat.OpenXml.Wordprocessing.GridAfter>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.GridBefore>> CollectGridBefores(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableRowProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableRowProperties, DocumentFormat.OpenXml.Wordprocessing.GridBefore>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Hidden>> CollectHiddens(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableRowProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableRowProperties, DocumentFormat.OpenXml.Wordprocessing.Hidden>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Inserted>> CollectInserteds(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableRowProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableRowProperties, DocumentFormat.OpenXml.Wordprocessing.Inserted>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableJustification>> CollectTableJustifications(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableRowProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableRowProperties, DocumentFormat.OpenXml.Wordprocessing.TableJustification>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCellSpacing>> CollectTableCellSpacings(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableRowProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableRowProperties, DocumentFormat.OpenXml.Wordprocessing.TableCellSpacing>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableHeader>> CollectTableHeaders(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableRowProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableRowProperties, DocumentFormat.OpenXml.Wordprocessing.TableHeader>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableRowHeight>> CollectTableRowHeights(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableRowProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableRowProperties, DocumentFormat.OpenXml.Wordprocessing.TableRowHeight>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableRowPropertiesChange>> CollectTableRowPropertiesChanges(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableRowProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableRowProperties, DocumentFormat.OpenXml.Wordprocessing.TableRowPropertiesChange>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.WidthAfterTableRow>> CollectWidthAfterTableRows(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableRowProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableRowProperties, DocumentFormat.OpenXml.Wordprocessing.WidthAfterTableRow>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.WidthBeforeTableRow>> CollectWidthBeforeTableRows(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableRowProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableRowProperties, DocumentFormat.OpenXml.Wordprocessing.WidthBeforeTableRow>();
    }
}

// Generated for type DocumentFormat.OpenXml.Wordprocessing.TableCell
static partial class OpenXmlExtensions
{
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.AltChunk>> CollectAltChunks(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCell> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableCell, DocumentFormat.OpenXml.Wordprocessing.AltChunk>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd>> CollectBookmarkEnds(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCell> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableCell, DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.BookmarkStart>> CollectBookmarkStarts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCell> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableCell, DocumentFormat.OpenXml.Wordprocessing.BookmarkStart>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd>> CollectCommentRangeEnds(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCell> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableCell, DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart>> CollectCommentRangeStarts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCell> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableCell, DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ContentPart>> CollectContentParts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCell> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableCell, DocumentFormat.OpenXml.Wordprocessing.ContentPart>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlBlock>> CollectCustomXmlBlocks(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCell> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableCell, DocumentFormat.OpenXml.Wordprocessing.CustomXmlBlock>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd>> CollectCustomXmlDelRangeEnds(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCell> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableCell, DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart>> CollectCustomXmlDelRangeStarts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCell> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableCell, DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd>> CollectCustomXmlInsRangeEnds(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCell> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableCell, DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart>> CollectCustomXmlInsRangeStarts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCell> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableCell, DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd>> CollectCustomXmlMoveFromRangeEnds(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCell> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableCell, DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart>> CollectCustomXmlMoveFromRangeStarts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCell> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableCell, DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd>> CollectCustomXmlMoveToRangeEnds(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCell> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableCell, DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart>> CollectCustomXmlMoveToRangeStarts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCell> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableCell, DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.DeletedRun>> CollectDeletedRuns(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCell> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableCell, DocumentFormat.OpenXml.Wordprocessing.DeletedRun>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.InsertedRun>> CollectInsertedRuns(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCell> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableCell, DocumentFormat.OpenXml.Wordprocessing.InsertedRun>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.MoveFromRun>> CollectMoveFromRuns(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCell> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableCell, DocumentFormat.OpenXml.Wordprocessing.MoveFromRun>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd>> CollectMoveFromRangeEnds(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCell> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableCell, DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart>> CollectMoveFromRangeStarts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCell> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableCell, DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.MoveToRun>> CollectMoveToRuns(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCell> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableCell, DocumentFormat.OpenXml.Wordprocessing.MoveToRun>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd>> CollectMoveToRangeEnds(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCell> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableCell, DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart>> CollectMoveToRangeStarts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCell> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableCell, DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Paragraph>> CollectParagraphs(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCell> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableCell, DocumentFormat.OpenXml.Wordprocessing.Paragraph>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.PermEnd>> CollectPermEnds(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCell> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableCell, DocumentFormat.OpenXml.Wordprocessing.PermEnd>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.PermStart>> CollectPermStarts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCell> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableCell, DocumentFormat.OpenXml.Wordprocessing.PermStart>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ProofError>> CollectProofErrors(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCell> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableCell, DocumentFormat.OpenXml.Wordprocessing.ProofError>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.SdtBlock>> CollectSdtBlocks(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCell> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableCell, DocumentFormat.OpenXml.Wordprocessing.SdtBlock>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Table>> CollectTables(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCell> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableCell, DocumentFormat.OpenXml.Wordprocessing.Table>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCellProperties>> CollectTableCellPropertiess(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCell> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableCell, DocumentFormat.OpenXml.Wordprocessing.TableCellProperties>();
    }
}

// Generated for type DocumentFormat.OpenXml.Wordprocessing.TableCellProperties
static partial class OpenXmlExtensions
{
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CellDeletion>> CollectCellDeletions(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCellProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableCellProperties, DocumentFormat.OpenXml.Wordprocessing.CellDeletion>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CellInsertion>> CollectCellInsertions(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCellProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableCellProperties, DocumentFormat.OpenXml.Wordprocessing.CellInsertion>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.CellMerge>> CollectCellMerges(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCellProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableCellProperties, DocumentFormat.OpenXml.Wordprocessing.CellMerge>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.ConditionalFormatStyle>> CollectConditionalFormatStyles(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCellProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableCellProperties, DocumentFormat.OpenXml.Wordprocessing.ConditionalFormatStyle>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.GridSpan>> CollectGridSpans(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCellProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableCellProperties, DocumentFormat.OpenXml.Wordprocessing.GridSpan>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.HorizontalMerge>> CollectHorizontalMerges(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCellProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableCellProperties, DocumentFormat.OpenXml.Wordprocessing.HorizontalMerge>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.HideMark>> CollectHideMarks(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCellProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableCellProperties, DocumentFormat.OpenXml.Wordprocessing.HideMark>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.NoWrap>> CollectNoWraps(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCellProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableCellProperties, DocumentFormat.OpenXml.Wordprocessing.NoWrap>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Shading>> CollectShadings(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCellProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableCellProperties, DocumentFormat.OpenXml.Wordprocessing.Shading>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCellBorders>> CollectTableCellBorderss(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCellProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableCellProperties, DocumentFormat.OpenXml.Wordprocessing.TableCellBorders>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCellFitText>> CollectTableCellFitTexts(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCellProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableCellProperties, DocumentFormat.OpenXml.Wordprocessing.TableCellFitText>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCellMargin>> CollectTableCellMargins(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCellProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableCellProperties, DocumentFormat.OpenXml.Wordprocessing.TableCellMargin>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCellPropertiesChange>> CollectTableCellPropertiesChanges(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCellProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableCellProperties, DocumentFormat.OpenXml.Wordprocessing.TableCellPropertiesChange>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCellWidth>> CollectTableCellWidths(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCellProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableCellProperties, DocumentFormat.OpenXml.Wordprocessing.TableCellWidth>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TextDirection>> CollectTextDirections(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCellProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableCellProperties, DocumentFormat.OpenXml.Wordprocessing.TextDirection>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCellVerticalAlignment>> CollectTableCellVerticalAlignments(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCellProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableCellProperties, DocumentFormat.OpenXml.Wordprocessing.TableCellVerticalAlignment>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.VerticalMerge>> CollectVerticalMerges(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCellProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.TableCellProperties, DocumentFormat.OpenXml.Wordprocessing.VerticalMerge>();
    }
}

// Generated for type DocumentFormat.OpenXml.Wordprocessing.TableCellWidth
static partial class OpenXmlExtensions
{
    public static ExtensionValue<DocumentFormat.OpenXml.StringValue> GetWidth(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCellWidth> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.TableCellWidth, DocumentFormat.OpenXml.StringValue>(new("Width", "w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Wordprocessing.TableWidthUnitValues>> GetType(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCellWidth> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.TableCellWidth, DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Wordprocessing.TableWidthUnitValues>>(new("Type", "type", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
}

// Generated for type DocumentFormat.OpenXml.Wordprocessing.TableCellVerticalAlignment
static partial class OpenXmlExtensions
{
    public static ExtensionValue<DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Wordprocessing.TableVerticalAlignmentValues>> GetVal(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TableCellVerticalAlignment> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.TableCellVerticalAlignment, DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Wordprocessing.TableVerticalAlignmentValues>>(new("Val", "val", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
}

// Generated for type DocumentFormat.OpenXml.Wordprocessing.HideMark
static partial class OpenXmlExtensions
{
    public static ExtensionValue<DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues>> GetVal(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.HideMark> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.HideMark, DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues>>(new("Val", "val", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
}

// Generated for type DocumentFormat.OpenXml.Wordprocessing.SectionProperties
static partial class OpenXmlExtensions
{
    public static ExtensionValue<DocumentFormat.OpenXml.HexBinaryValue> GetRsidRPr(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.SectionProperties> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.SectionProperties, DocumentFormat.OpenXml.HexBinaryValue>(new("RsidRPr", "rsidRPr", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.HexBinaryValue> GetRsidDel(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.SectionProperties> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.SectionProperties, DocumentFormat.OpenXml.HexBinaryValue>(new("RsidDel", "rsidDel", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.HexBinaryValue> GetRsidR(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.SectionProperties> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.SectionProperties, DocumentFormat.OpenXml.HexBinaryValue>(new("RsidR", "rsidR", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.HexBinaryValue> GetRsidSect(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.SectionProperties> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.SectionProperties, DocumentFormat.OpenXml.HexBinaryValue>(new("RsidSect", "rsidSect", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.BiDi>> CollectBiDis(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.SectionProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.SectionProperties, DocumentFormat.OpenXml.Wordprocessing.BiDi>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Columns>> CollectColumnss(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.SectionProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.SectionProperties, DocumentFormat.OpenXml.Wordprocessing.Columns>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.DocGrid>> CollectDocGrids(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.SectionProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.SectionProperties, DocumentFormat.OpenXml.Wordprocessing.DocGrid>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.EndnoteProperties>> CollectEndnotePropertiess(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.SectionProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.SectionProperties, DocumentFormat.OpenXml.Wordprocessing.EndnoteProperties>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.FooterReference>> CollectFooterReferences(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.SectionProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.SectionProperties, DocumentFormat.OpenXml.Wordprocessing.FooterReference>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.FootnoteProperties>> CollectFootnotePropertiess(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.SectionProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.SectionProperties, DocumentFormat.OpenXml.Wordprocessing.FootnoteProperties>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.FormProtection>> CollectFormProtections(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.SectionProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.SectionProperties, DocumentFormat.OpenXml.Wordprocessing.FormProtection>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.HeaderReference>> CollectHeaderReferences(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.SectionProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.SectionProperties, DocumentFormat.OpenXml.Wordprocessing.HeaderReference>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.LineNumberType>> CollectLineNumberTypes(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.SectionProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.SectionProperties, DocumentFormat.OpenXml.Wordprocessing.LineNumberType>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.NoEndnote>> CollectNoEndnotes(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.SectionProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.SectionProperties, DocumentFormat.OpenXml.Wordprocessing.NoEndnote>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.PaperSource>> CollectPaperSources(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.SectionProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.SectionProperties, DocumentFormat.OpenXml.Wordprocessing.PaperSource>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.PageBorders>> CollectPageBorderss(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.SectionProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.SectionProperties, DocumentFormat.OpenXml.Wordprocessing.PageBorders>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.PageMargin>> CollectPageMargins(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.SectionProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.SectionProperties, DocumentFormat.OpenXml.Wordprocessing.PageMargin>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.PageNumberType>> CollectPageNumberTypes(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.SectionProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.SectionProperties, DocumentFormat.OpenXml.Wordprocessing.PageNumberType>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.PageSize>> CollectPageSizes(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.SectionProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.SectionProperties, DocumentFormat.OpenXml.Wordprocessing.PageSize>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.PrinterSettingsReference>> CollectPrinterSettingsReferences(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.SectionProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.SectionProperties, DocumentFormat.OpenXml.Wordprocessing.PrinterSettingsReference>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.GutterOnRight>> CollectGutterOnRights(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.SectionProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.SectionProperties, DocumentFormat.OpenXml.Wordprocessing.GutterOnRight>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.SectionPropertiesChange>> CollectSectionPropertiesChanges(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.SectionProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.SectionProperties, DocumentFormat.OpenXml.Wordprocessing.SectionPropertiesChange>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TextDirection>> CollectTextDirections(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.SectionProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.SectionProperties, DocumentFormat.OpenXml.Wordprocessing.TextDirection>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.TitlePage>> CollectTitlePages(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.SectionProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.SectionProperties, DocumentFormat.OpenXml.Wordprocessing.TitlePage>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.SectionType>> CollectSectionTypes(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.SectionProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.SectionProperties, DocumentFormat.OpenXml.Wordprocessing.SectionType>();
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.VerticalTextAlignmentOnPage>> CollectVerticalTextAlignmentOnPages(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.SectionProperties> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.SectionProperties, DocumentFormat.OpenXml.Wordprocessing.VerticalTextAlignmentOnPage>();
    }
}

// Generated for type DocumentFormat.OpenXml.Wordprocessing.PageSize
static partial class OpenXmlExtensions
{
    public static ExtensionValue<DocumentFormat.OpenXml.UInt32Value> GetWidth(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.PageSize> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.PageSize, DocumentFormat.OpenXml.UInt32Value>(new("Width", "w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.UInt32Value> GetHeight(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.PageSize> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.PageSize, DocumentFormat.OpenXml.UInt32Value>(new("Height", "h", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Wordprocessing.PageOrientationValues>> GetOrient(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.PageSize> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.PageSize, DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Wordprocessing.PageOrientationValues>>(new("Orient", "orient", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.UInt16Value> GetCode(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.PageSize> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.PageSize, DocumentFormat.OpenXml.UInt16Value>(new("Code", "code", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
}

// Generated for type DocumentFormat.OpenXml.Wordprocessing.PageMargin
static partial class OpenXmlExtensions
{
    public static ExtensionValue<DocumentFormat.OpenXml.Int32Value> GetTop(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.PageMargin> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.PageMargin, DocumentFormat.OpenXml.Int32Value>(new("Top", "top", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.UInt32Value> GetRight(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.PageMargin> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.PageMargin, DocumentFormat.OpenXml.UInt32Value>(new("Right", "right", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.Int32Value> GetBottom(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.PageMargin> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.PageMargin, DocumentFormat.OpenXml.Int32Value>(new("Bottom", "bottom", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.UInt32Value> GetLeft(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.PageMargin> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.PageMargin, DocumentFormat.OpenXml.UInt32Value>(new("Left", "left", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.UInt32Value> GetHeader(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.PageMargin> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.PageMargin, DocumentFormat.OpenXml.UInt32Value>(new("Header", "header", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.UInt32Value> GetFooter(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.PageMargin> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.PageMargin, DocumentFormat.OpenXml.UInt32Value>(new("Footer", "footer", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.UInt32Value> GetGutter(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.PageMargin> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.PageMargin, DocumentFormat.OpenXml.UInt32Value>(new("Gutter", "gutter", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
}

// Generated for type DocumentFormat.OpenXml.Wordprocessing.Columns
static partial class OpenXmlExtensions
{
    public static ExtensionValue<DocumentFormat.OpenXml.OnOffValue> GetEqualWidth(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Columns> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.Columns, DocumentFormat.OpenXml.OnOffValue>(new("EqualWidth", "equalWidth", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.StringValue> GetSpace(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Columns> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.Columns, DocumentFormat.OpenXml.StringValue>(new("Space", "space", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.Int16Value> GetColumnCount(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Columns> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.Columns, DocumentFormat.OpenXml.Int16Value>(new("ColumnCount", "num", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.OnOffValue> GetSeparator(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Columns> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.Columns, DocumentFormat.OpenXml.OnOffValue>(new("Separator", "sep", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static IEnumerable<ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Column>> CollectColumns(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.Columns> element)
    {
        return element.GetChildren<DocumentFormat.OpenXml.Wordprocessing.Columns, DocumentFormat.OpenXml.Wordprocessing.Column>();
    }
}

// Generated for type DocumentFormat.OpenXml.Wordprocessing.BiDi
static partial class OpenXmlExtensions
{
    public static ExtensionValue<DocumentFormat.OpenXml.OnOffValue> GetVal(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.BiDi> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.BiDi, DocumentFormat.OpenXml.OnOffValue>(new("Val", "val", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
}

// Generated for type DocumentFormat.OpenXml.Wordprocessing.GutterOnRight
static partial class OpenXmlExtensions
{
    public static ExtensionValue<DocumentFormat.OpenXml.OnOffValue> GetVal(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.GutterOnRight> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.GutterOnRight, DocumentFormat.OpenXml.OnOffValue>(new("Val", "val", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
}

// Generated for type DocumentFormat.OpenXml.Wordprocessing.DocGrid
static partial class OpenXmlExtensions
{
    public static ExtensionValue<DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Wordprocessing.DocGridValues>> GetType(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.DocGrid> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.DocGrid, DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Wordprocessing.DocGridValues>>(new("Type", "type", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.Int32Value> GetLinePitch(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.DocGrid> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.DocGrid, DocumentFormat.OpenXml.Int32Value>(new("LinePitch", "linePitch", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
    public static ExtensionValue<DocumentFormat.OpenXml.Int32Value> GetCharacterSpace(this ExtensionElement<DocumentFormat.OpenXml.Wordprocessing.DocGrid> element)
    {
        return element.GetAttribute<DocumentFormat.OpenXml.Wordprocessing.DocGrid, DocumentFormat.OpenXml.Int32Value>(new("CharacterSpace", "charSpace", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w"));
    }
}

Add-Type -Path .\Packages\system.io.packaging.6.0.0\lib\net6.0\System.IO.Packaging.dll
Add-Type -Path .\Packages\documentformat.openxml.2.15.0\lib\netstandard2.0\DocumentFormat.OpenXml.dll
[System.Environment]::CurrentDirectory = $PWD.Path
$d = [DocumentFormat.OpenXml.Packaging.WordprocessingDocument]::Open(".\Documents\وسائل الشيعة.docx", $false)
$EM = [DocumentFormat.OpenXml.Wordprocessing.Paragraph].Assembly.GetType('DocumentFormat.OpenXml.Framework.Metadata.ElementMetadata')
[Ks.Common.ConsoleTreeDrawer[type]]::CreateFromChildren([type[]]@([DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties]), { param([type]$t) [type[]]@($EM::Create($t::New()).Children.Elements | % Type) })
[type[]]@([DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties])
[type[]]@([DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties]).GetType()
([type[]]@([DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties])).GetType()
$t = [DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties]
[type[]]@($EM::Create($t::New()).Children.Elements | % Type)
([type[]]@($EM::Create($t::New()).Children.Elements | % Type)).GetType()
[Ks.Common.ConsoleTreeDrawer[type]]::CreateFromChildren([type[]]@([DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties]), { param([type]$t) Return [type[]]@($EM::Create($t::New()).Children.Elements | % Type) })
[Ks.Common.ConsoleTreeDrawer[type]]::CreateFromChildren(@([DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties]), { param([object]$t) Return @($EM::Create($t::New()).Children.Elements | % Type) }, { param([object]$t) [type]$t})
[Ks.Common.ConsoleTreeDrawer[type]]::CreateFromChildren(@([DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties]), { param([object]$t) Return @($EM::Create($t::New()).Children.Elements | % Type) }, { param([object]$t) [type]$t })
$CTD = [Ks.Common.ConsoleTreeDrawer[type]]::CreateEmpty()
function Ctd-Add([type]$t) { $EM::Create($t::New()).Children.Elements | % Type | % { [void] $CTD.Dic.Item($t).Add($_); Ctd-Add $_ } }
Ctd-Add ([DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties])
$CTD.MakeTree()
$CTD.MakeTree() > ChildTree.txt

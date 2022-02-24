Add-Type -Path .\Packages\system.io.packaging.6.0.0\lib\net6.0\System.IO.Packaging.dll
Add-Type -Path .\Packages\documentformat.openxml.2.15.0\lib\netstandard2.0\DocumentFormat.OpenXml.dll
[System.Environment]::CurrentDirectory = $PWD.Path
$d = [DocumentFormat.OpenXml.Packaging.WordprocessingDocument]::Open(".\Documents\وسائل الشيعة.docx", $false)
$EM = [DocumentFormat.OpenXml.Wordprocessing.Paragraph].Assembly.GetType('DocumentFormat.OpenXml.Framework.Metadata.ElementMetadata')
$pmd = $EM::Create([DocumentFormat.OpenXml.Wordprocessing.Paragraph]::New())
$pmd = $EM::Create([DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties]::New())
Tree-Types -IncludeBases ($pmd.Children.Elements | % Type)
Tree-Types -IncludeBases ($pmd.Children.Elements | % Type) | clip
$pmd.Children.Elements | % Type | % Name
$pmd.Children.Elements | % Type | % Name | Join-String '|'
$pmd.Children.Elements | % Type | % Name | Join-String '|' | clip
h
h | % CommandLine

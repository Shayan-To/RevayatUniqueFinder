$host.UI.RawUI.WindowTitle = 'PowerShell 7 (x64)'
Add-Type -Path .\Packages\system.io.packaging.6.0.0\lib\net6.0\System.IO.Packaging.dll
Add-Type -Path .\Packages\documentformat.openxml.2.15.0\lib\netstandard2.0\DocumentFormat.OpenXml.dll
Add-Type -Path .\Packages\docx.2.0.0\lib\net40\Xceed.Document.NET.dll
Add-Type -Path .\Packages\docx.2.0.0\lib\net40\Xceed.Words.NET.dll
[Xceed.Words.NET.DocX]::Load
[System.Environment]::CurrentDirectory = $PWD.Path
[Xceed.Words.NET.DocX]::Load(".\Documents\وسائل الشيعة.docx")
$doc = [Xceed.Words.NET.DocX]::Load(".\Documents\وسائل الشيعة.docx")
$doc
$doc | gm
$doc | gm
$doc.Sections | gm
$doc.Sections.count
$doc.Paragraphs.Count
$doc.Paragraphs | select -First 10
$doc.Paragraphs | select -First 1
$p = $doc.Paragraphs | select -First 1
$p
h
h | % CommandLine
$p.GetType()
$p.GetType().BaseType
$p.GetType().BaseType.BaseType
$doc | gm
$doc.Sections[0].GetType()
$doc.Sections[0].GetType().base
$doc.Sections[0].GetType().BaseType
$doc.Xml
$doc.Xml | gm
$doc.Xml.Name
$doc.Xml.Elements().count
$doc.Xml.Elements() | measure
$doc.Paragraphs.Count
$el = @($doc.Xml.Elements())
$el.Length
$el | % name | select -Unique-
$el | % name | select -Unique
$el | group name
$el | group name | ft -AutoSize
$el | ? Name -eq 'sectPr'
$el[0].Name.LocalName
$el | ? Name.LocalName -eq 'sectPr'
$el | ? { $_.Name.LocalName -eq 'sectPr' }
$sect = $el | ? { $_.Name.LocalName -eq 'sectPr' }
$sect.Valuel
$sect.Value
$sect | gm
$sect.ToString()
[array]::IndexOf($el, $sect)
[array]::IndexOf($el, 0)
$el.Length
$ts = $el | ? { $_.Name.LocalName -eq 'tbl' }
$ts.Length
$ts | % { [array]::IndexOf($el, $_) }
$doc.Tables.Count
$doc.Tables[0]
$doc.Tables[0].GetType()
$doc.Tables[0].GetType().Assembly.GetTypes() | ? BaseType -eq ([Xceed.Document.NET.InsertBeforeOrAfter])
$doc.Paragraphs.Count
$doc.Tables[0].Paragraphs[0]
$doc.Tables[0].Rows[0]
$doc.Tables[0].Rows[0].Cells[0]
$d = [DocumentFormat.OpenXml.Packaging.WordprocessingDocument]::Open(".\Documents\وسائل الشيعة.docx", false)
$d = [DocumentFormat.OpenXml.Packaging.WordprocessingDocument]::Open(".\Documents\وسائل الشيعة.docx", $false)
$d.MainDocumentPart.Document.Body.GetType()
$d.MainDocumentPart.Document.Body.GetType().BaseType
$d.MainDocumentPart.Document.Body.GetType().BaseType.BaseType
$d.MainDocumentPart.Document.Body.GetType().BaseType.BaseType.BaseType
$d.MainDocumentPart.Document.Body | gm
$d.MainDocumentPart.Document.Body | measure
@($d.MainDocumentPart.Document.Body) | gm
$d.MainDocumentPart.Document.Body.GetType().interfaces
$d.MainDocumentPart.Document.Body.GetType().getinterfaces()
gm $d.MainDocumentPart.Document.Body
gm ($d.MainDocumentPart.Document.Body)
gm -InputObject ($d.MainDocumentPart.Document.Body)
$d.MainDocumentPart.Document.Body.ChildElements
$d.MainDocumentPart.Document.Body.ChildElements[0]
$d.MainDocumentPart.Document.Body.ChildElements[0] | gm
gm -InputObject ($d.MainDocumentPart.Document.Body.ChildElements[0])
$d.MainDocumentPart.Document.Body.ChildElements[0].GetType().GetMembers()
$d.MainDocumentPart.Document.Body.ChildElements[0].GetType().GetMembers() | % Name
$d.MainDocumentPart.Document.Body.ChildElements[0].GetType().GetMembers()[0]
$d.MainDocumentPart.Document.Body.ChildElements[0].GetType().GetMembers() | ? DeclaringType -eq [paragraph]
$d.MainDocumentPart.Document.Body.ChildElements[0].GetType().GetMembers() | ? DeclaringType -eq ([DocumentFormat.OpenXml.Wordprocessing.Paragraph])
$d.MainDocumentPart.Document.Body.ChildElements[0].GetType().GetMembers() | ? DeclaringType -eq ([DocumentFormat.OpenXml.Wordprocessing.Paragraph]) | % Name
$d.MainDocumentPart.Document.Body.ChildElements[0].ChildElements.GetType()
[DocumentFormat.OpenXml.Wordprocessing.Paragraph].GetCustomAttributes([DocumentFormat.OpenXml.ChildElementInfoAttribute])
[DocumentFormat.OpenXml.Wordprocessing.Paragraph].GetCustomAttributes([DocumentFormat.OpenXml.ChildElementInfoAttribute], $false)
[DocumentFormat.OpenXml.Wordprocessing.Paragraph].CustomAttributes
[DocumentFormat.OpenXml.Wordprocessing.Paragraph].Assembly
$d.MainDocumentPart.Document.Body.ChildElements[0].Features
[DocumentFormat.OpenXml.Framework.Metadata.ElementMetadata]
[DocumentFormat.OpenXml.Wordprocessing.Paragraph].Assembly.GetType('DocumentFormat.OpenXml.Framework.Metadata.ElementMetadata')
$EM = [DocumentFormat.OpenXml.Wordprocessing.Paragraph].Assembly.GetType('DocumentFormat.OpenXml.Framework.Metadata.ElementMetadata')
$EM::Create($d.MainDocumentPart.Document.Body.ChildElements[0])
$EM::Create($d.MainDocumentPart.Document.Body.ChildElements[0]).children
$EM::Create($d.MainDocumentPart.Document.Body.ChildElements[0]).children | fl * -Force
$EM::Create($d.MainDocumentPart.Document.Body.ChildElements[0]).children.elements
$EM::Create($d.MainDocumentPart.Document.Body.ChildElements[0]).children.elements.gettype()
$pmd = $EM::Create($d.MainDocumentPart.Document.Body.ChildElements[0])
$pmd.Children.Elements | % Type
Tree-Types ($pmd.Children.Elements | % Type)
Load-Assembly 'D:\Shayan\MyDocuments\Coding\Projects\Parmyn\KsCommonLibrary\bin\Debug\netstandard2.0\KsCommonLibrary.dll'
Tree-Types ($pmd.Children.Elements | % Type)

Function Include-TypeBases([Type[]] $Types)
{
    $Types | % { [Ks.Common.CommonExtensions]::GetBaseTypes($_) } | select -Unique
}

Tree-Types (Include-TypeBases ($pmd.Children.Elements | % Type))
Include-TypeBases ($pmd.Children.Elements | % Type)
Tree-Types (Include-TypeBases ($pmd.Children.Elements | % Type))
. Run-Script Tree-TypeDescendants
Tree-Types (Include-TypeBases ($pmd.Children.Elements | % Type))
$abc
$abc.Dic
TreeTypeRec $abc.Dic ([object])
TreeTypeRec $abc.Dic ([object])
$abc.Dic[[object]]
$abc.Dic[[object]].Count
$abc.Dic[[object]][0]
$abc.Dic[$abc.Dic[[object]][0]]
. Run-Script Tree-TypeDescendants
. Run-Script Tree-TypeDescendants
Tree-Types ($pmd.Children.Elements | % Type)
Tree-Types -IncludeBases ($pmd.Children.Elements | % Type)
. Run-Script Tree-TypeDescendants
Tree-Types -IncludeBases ($pmd.Children.Elements | % Type)
Add-Type -Path D:\Shayan\MyDocuments\Coding\Projects\RevayatUniqueFinder\Scripts\Packages\system.io.packaging.6.0.0\lib\net6.0\System.IO.Packaging.dll
Add-Type -Path D:\Shayan\MyDocuments\Coding\Projects\RevayatUniqueFinder\Scripts\Packages\documentformat.openxml.2.15.0\lib\netstandard2.0\DocumentFormat.OpenXml.dll
$EM = [DocumentFormat.OpenXml.Wordprocessing.Paragraph].Assembly.GetType('DocumentFormat.OpenXml.Framework.Metadata.ElementMetadata')
$pmd = $EM::Create([DocumentFormat.OpenXml.Wordprocessing.Paragraph]::New())
Tree-Types (Include-TypeBases ($pmd.Children.Elements | % Type))
#CLIPBOARD!!!
Tree-Types (Include-TypeBases ($pmd.Children.Elements | % Type) | sort fullName)
Include-TypeBases ($pmd.Children.Elements | % Type)
Include-TypeBases ($pmd.Children.Elements | % Type) | % fullname
Include-TypeBases ($pmd.Children.Elements | % Type) | sort fullname | % fullname
Tree-Types -InterfaceAsClass ($pmd.Children.Elements | % Type)
Tree-Types -IncludeBases ($pmd.Children.Elements | % Type)
. Run-Script Tree-TypeDescendants
Tree-Types -IncludeBases ($pmd.Children.Elements | % Type)
Tree-Types -IncludeBases ($pmd.Children.Elements | % Type) | clip
Tree-Types -IncludeBases ($pmd.Children.Elements | % Type) | clip
. Run-Script Tree-TypeDescendants
Tree-Types -IncludeBases ($pmd.Children.Elements | % Type) | clip
Tree-Types -IncludeBases ($pmd.Children.Elements | % Type) -NoSort | clip
. Run-Script Tree-TypeDescendants
Tree-Types -IncludeBases ($pmd.Children.Elements | % Type)

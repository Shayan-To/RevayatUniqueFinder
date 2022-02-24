ls .\Packages\
Add-Type -Path .\Packages\system.io.packaging.6.0.0\lib\net6.0\System.IO.Packaging.dll
Add-Type -Path .\Packages\documentformat.openxml.2.15.0\lib\netstandard2.0\DocumentFormat.OpenXml.dll
Add-Type -Path .\Packages\docx.2.0.0\lib\net40\Xceed.Document.NET.dll
Add-Type -Path .\Packages\docx.2.0.0\lib\net40\Xceed.Words.NET.dll
[System.Environment]::CurrentDirectory = $PWD.Path
$doc = [Xceed.Words.NET.DocX]::Load(".\Documents\وسائل الشيعة.docx")
$p = $doc.Paragraphs | select -First 1
$p
$p | gm
$p | fl * -Force
$p | gm
$p.StyleId
$p.StyleName
$p.Color
$p.Color()
$p.MagicText.count
$p.MagicText
$p.MagicText | fl * -Force
$p.MagicText[0].formatting
$t = $doc.Paragraphs | select -First 100 | % MagicText
$t.Count
$t | % formatting
$t
$t | % formatting
$s = $t | % formatting | Out-String
$s.count
$s.Length
$s = $t | % formatting | Out-String
$s
$s = $s -split '\r?\n'
$s.Length
$s.Length | sort -Unique
$s | sort -Unique
$doc.Paragraphs | % MagicText | % { ($_ | % formatting | Out-String) -split '\r?\n' } | select -Unique
$doc.Paragraphs | % { $_.MagicText.count } | measure -Sum
$doc.Paragraphs[0]

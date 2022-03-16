Add-Type -Path .\bin\Debug\net6.0\System.IO.Packaging.dll
Add-Type -Path .\bin\Debug\net6.0\DocumentFormat.OpenXml.dll

$OpenXmlAssembly = [DocumentFormat.OpenXml.Wordprocessing.Paragraph].Assembly
$ElementMetadata = $OpenXmlAssembly.GetType('DocumentFormat.OpenXml.Framework.Metadata.ElementMetadata')

<#
$Md = $ElementMetadata::Create([DocumentFormat.OpenXml.Wordprocessing.Paragraph]::New())
#>

Function Generate($Md, $ChildFilter)
{
    Write-Output @"

// Generated for type $($Md.Type.FullName)
static partial class OpenXmlExtensions
{
"@
    ForEach ($Att In $Md.Attributes)
    {
        Write-Output @"
    public static $($Att.Type.FullName) Get$($Att.PropertyName)(this $($Md.Type.FullName) element)
    {
        return element.GetAttribute<$($Att.Type.FullName)>("$($Att.PropertyName)", "$($Att.QName.Namespace.Uri)", "$($Att.QName.Name)");
    }
"@
    }
    If ($Null -NE $ChildFilter)
    {
        $ChildFilter = [Regex]::New("^$ChildFilter`$")
        ForEach ($Ch In $Md.Children.Elements)
        {
            If (-Not $ChildFilter.IsMatch($Ch.Type.FullName))
            {
                Continue
            }
            Write-Output @"
    public static IEnumerable<$($Ch.Type.FullName)> Collect$($Ch.Type.Name)s(this $($Md.Type.FullName) element)
    {
        return element.GetChildren<$($Ch.Type.FullName)>();
    }
"@
        }
    }
    Write-Output "}"
}

$OutFile = "$PSScriptRoot\OpenXmlExtensions.g.cs"
New-Item -Force -ItemType File $OutFile | Out-Null
"namespace RevayatUniqueFinder;" | Out-File -Append $OutFile

ForEach ($Type In Get-Content "$PSScriptRoot\Types.txt")
{
    $SType = $Type -Split '>', 2
    Generate ($ElementMetadata::Create($OpenXmlAssembly.GetType($SType[0])::New())) ($SType[1]) | Out-File -Append $OutFile
}

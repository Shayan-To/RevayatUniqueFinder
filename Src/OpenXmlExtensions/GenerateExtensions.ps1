Add-Type -Path .\bin\Debug\net6.0\System.IO.Packaging.dll
Add-Type -Path .\bin\Debug\net6.0\DocumentFormat.OpenXml.dll

$OpenXmlAssembly = [DocumentFormat.OpenXml.Wordprocessing.Paragraph].Assembly
$ElementMetadata = $OpenXmlAssembly.GetType('DocumentFormat.OpenXml.Framework.Metadata.ElementMetadata')

<#
$Md = $ElementMetadata::Create([DocumentFormat.OpenXml.Wordprocessing.Paragraph]::New())
#>

Function GetFullName([Type] $Type)
{
    If ($Type.IsGenericType)
    {
        Return "$($Type.Namespace).$($Type.Name -Replace '`\d+$')<$($Type.GenericTypeArguments | % { GetFullName $_ } | Join-String -Separator ", ")>"
    }
    Return $Type.FullName
}

Function Generate($Md, $ChildFilter)
{
    Write-Output @"

// Generated for type $(GetFullName $Md.Type)
static partial class OpenXmlExtensions
{
"@
    ForEach ($Att In $Md.Attributes)
    {
        Write-Output @"
    public static ExtensionValue<$(GetFullName $Att.Type)> Get$($Att.PropertyName)(this ExtensionElement<$(GetFullName $Md.Type)> element)
    {
        return element.GetAttribute<$(GetFullName $Md.Type), $(GetFullName $Att.Type)>(new("$($Att.PropertyName)", "$($Att.QName.Name)", "$($Att.QName.Namespace.Uri)", "$($Att.QName.Namespace.Prefix)"));
    }
"@
    }
    If ($Null -NE $ChildFilter)
    {
        $ChildFilter = [Regex]::New("^$ChildFilter`$")
        ForEach ($Ch In $Md.Children.Elements)
        {
            If (-Not $ChildFilter.IsMatch((GetFullName $Ch.Type)))
            {
                Continue
            }
            Write-Output @"
    public static IEnumerable<ExtensionElement<$(GetFullName $Ch.Type)>> Collect$($Ch.Type.Name)s(this ExtensionElement<$(GetFullName $Md.Type)> element)
    {
        return element.GetChildren<$(GetFullName $Md.Type), $(GetFullName $Ch.Type)>();
    }
"@
        }
    }
    Write-Output "}"
}

Function GenerateAttributeData
{
    Write-Output @"

static partial class OpenXmlExtensions
{
    public static readonly IReadOnlyList<AttributeData> AttributesData = new System.Collections.ObjectModel.ReadOnlyCollection<AttributeData>(new AttributeData[]
    {
#if FullBuild
"@

    ForEach ($Type In $OpenXmlAssembly.GetTypes())
    {
        If (-Not ($Type.IsAssignableTo([DocumentFormat.OpenXml.OpenXmlElement]) -And $Type.IsPublic -And -Not $Type.IsAbstract -And $Null -NE $Type.GetConstructor(@())))
        {
            Continue
        }
        $Md = $ElementMetadata::Create($Type::New())
        ForEach ($Att In $Md.Attributes)
        {
            Write-Output @"
        new(typeof($(GetFullName $Md.Type)), typeof($(GetFullName $Att.Type)), new("$($Att.PropertyName)", "$($Att.QName.Name)", "$($Att.QName.Namespace.Uri)", "$($Att.QName.Namespace.Prefix)")),
"@
        }
    }
    Write-Output @"
#endif
    });
}
"@
}

$OutFile = "$PSScriptRoot\OpenXmlExtensions.g.cs"
New-Item -Force -ItemType File $OutFile | Out-Null
"namespace RevayatUniqueFinder;" | Out-File -Append $OutFile

& {
    ForEach ($Type In Get-Content "$PSScriptRoot\Types.txt")
    {
        $SType = $Type -Split '>', 2
        Generate ($ElementMetadata::Create($OpenXmlAssembly.GetType($SType[0])::New())) ($SType[1])
    }
} | Out-File -Append $OutFile

$OutFile = "$PSScriptRoot\OpenXmlExtensions.Attributes.g.cs"
New-Item -Force -ItemType File $OutFile | Out-Null
"namespace RevayatUniqueFinder;" | Out-File -Append $OutFile
GenerateAttributeData | Out-File -Append $OutFile

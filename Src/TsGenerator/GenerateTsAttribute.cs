using System.Reflection;

namespace RevayatUniqueFinder;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface | AttributeTargets.Enum)]
public class GenerateTsAttribute : Attribute
{
}

namespace RevayatUniqueFinder;

public static class Paths
{
    public static string Documents { get; } = PathAttribute.GetPath("Documents") ?? throw Assert.Fail($"Could not find path '{nameof(Documents)}'.");
    public static string GenOutput { get; } = PathAttribute.GetPath("GenOutput") ?? throw Assert.Fail($"Could not find path '{nameof(GenOutput)}'.");
}

namespace Server.Zulu.Crafting;

public class ZuluCraftSubRes
{
    public ZuluCraftSubRes(int materialId, string message = null)
    {
        MaterialId = materialId;
        Message = message;
    }

    public int MaterialId { get; }
    public string Message { get; }

    public ZuluMaterialDefinition Definition => ZuluMaterialRegistry.Get(MaterialId);
    public string Name => Definition?.Name ?? "?";
    public double RequiredSkill => Definition?.Difficulty ?? 0.0;
}

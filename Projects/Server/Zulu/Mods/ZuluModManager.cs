namespace Server;

public static class ZuluModManager
{

}

public abstract class ZuluModBase : IZuluMod
{
    public abstract string Name { get; }

    public abstract int Cap { get; }

    public abstract string Description_PtBR { get; }

    public abstract string Description_EnUS { get; }
}

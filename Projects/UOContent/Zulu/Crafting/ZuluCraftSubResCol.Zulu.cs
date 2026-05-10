using System.Collections.Generic;

namespace Server.Zulu.Crafting;

public class ZuluCraftSubResCol
{
    private readonly List<ZuluCraftSubRes> _list = new();

    public string NameString { get; set; }
    public bool Init { get; set; }

    public int Count => _list.Count;

    public void Add(ZuluCraftSubRes subRes) => _list.Add(subRes);

    public ZuluCraftSubRes GetAt(int index) => _list[index];

    public ZuluCraftSubRes SearchFor(int materialId)
    {
        foreach (var sr in _list)
        {
            if (sr.MaterialId == materialId)
            {
                return sr;
            }
        }
        return null;
    }

    public IReadOnlyList<ZuluCraftSubRes> AsReadOnly() => _list;
}

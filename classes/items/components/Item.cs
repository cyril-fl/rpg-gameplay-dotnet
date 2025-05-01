namespace rpg_gameplay.classes.items.components;
public class Item
{
    public int Id { get; }
    public string Name { get; }
    public string Description { get; }
    public int Rarity { get; }

    protected Item(int id, string name, string description, int rarity)
    {
        Id = id;
        Name = name;
        Description = description;
        Rarity = rarity;
    }
}
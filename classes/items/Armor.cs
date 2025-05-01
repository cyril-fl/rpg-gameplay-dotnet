using rpg_gameplay.classes.items.components;

namespace rpg_gameplay.classes.items;

public enum ArmorType
{
    Light,
    Medium,
    Heavy
}
public class Armor : Equipment<ArmorType>
{
    public Armor(int id, string name, string description, int rarity, int defense, int attack, int level, ArmorType type)
        : base(id, name, description, rarity, defense, attack, level, type)
    {
    }
}
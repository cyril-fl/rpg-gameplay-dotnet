using rpg_gameplay.model.inventory.components;

namespace rpg_gameplay.model.inventory;
public class Inventory
{
    public Purse Purse { get; }
    public Weapon? Weapon { get; set; }
    public Armor? Armor { get; set; }
    public List<Item> Items { get; set; } 


    public Inventory(Weapon? weapon, Armor? armor)
    {
        Weapon = weapon;
        Armor = armor;
        Items = [];
        Purse = new Purse(0, 0, 0);
    }
    
}
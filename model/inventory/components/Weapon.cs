namespace rpg_gameplay.model.inventory.components;

public enum WeaponType
{
    GreatSword,
    SwordAndShield,
    Bow,
    Dagger,
    Axe
}
public class Weapon : Equipment<WeaponType>
{
    public Weapon(int id, string name, string description, int rarity, int defense, int attack, int level, WeaponType type)
        : base(id, name, description, rarity, defense, attack, level, type)
    {
    }
}
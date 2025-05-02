namespace rpg_gameplay.classes.inventory.components;
public class Equipment<T> : Item
{
    public int Def { get; }
    public int Atk { get; }
    public int Lvl { get; }
    public T Type { get; }

    protected Equipment(int id, string name, string description, int rarity, int defense, int attack, int level, T type) 
        : base(id, name, description, rarity)
    {
        Def = defense;
        Atk = attack;
        Lvl = level;
        Type = type;
    }
}
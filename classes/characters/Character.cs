using rpg_gameplay.classes.characters.components;
using rpg_gameplay.classes.items;
using rpg_gameplay.classes.items.components;
namespace rpg_gameplay.classes.characters;

public class Character
{
    public string Name { get; }
    public Role Role { get; }
    public Tribe Tribe { get; }
    public StatList Stats { get; }
    public Level Level { get; }
    public List<Item> Inventory { get; } = [];
    public Weapon? Weapon { get; set; }
    public Armor? Armor { get; set; }


    public Character(string name, Tribe tribe, Role role)
    {
        Name = name;
        Tribe = tribe;
        Role = role;
        Stats = StatListFactory.MergeList([ tribe.Stats, role.Stats ]);
        Level = new Level();
    }
    public Character(string name, Tribe tribe, Role role, StatList stats, Level level)
    {
        Name = name;
        Tribe = tribe;
        Role = role;
        Stats = stats;
        Level = level;
    }
}

public static class CharacterFactory
{
    public static Character Create(string name, TribeType tribeType, RoleType roleType)
    {
        var tribe = TribeFactory.Create(tribeType);
        var role = RoleFactory.Create(roleType);
        var stats = StatListFactory.MergeList([ tribe.Stats, role.Stats ]);
        var level = new Level();

        return new Character(name, tribe, role, stats, level);
    }
}
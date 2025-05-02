using rpg_gameplay.classes.characters.components;
using rpg_gameplay.classes.inventory;
namespace rpg_gameplay.classes.characters;

public class Character
{
    public string Name { get; }
    public Role Role { get; }
    public Tribe Tribe { get; }
    public StatList Stats { get; }
    public Level Level { get; }
    public Inventory Inventory { get; }



    public Character(string name, Tribe tribe, Role role,  Inventory inventory)
    {
        Name = name;
        Tribe = tribe;
        Role = role;
        Stats = StatListFactory.MergeList([ tribe.Stats, role.Stats ]);
        Level = new Level();
        Inventory = inventory;
    }
    public Character(string name, Tribe tribe, Role role, StatList stats, Level level, Inventory inventory)
    {
        Name = name;
        Tribe = tribe;
        Role = role;
        Stats = stats;
        Level = level;
        Inventory = inventory;
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
        // TODO: utiliser une facrory pour que en fonction de la classe et du role donnée une arme par defaut
        var inventory = new Inventory(null, null);

        return new Character(name, tribe, role, stats, level, inventory);
    }
}
using rpg_gameplay.logic.enums;
using rpg_gameplay.logic.factories;
using rpg_gameplay.model.characters.components;
using rpg_gameplay.model.inventory;
namespace rpg_gameplay.model.characters;

public class Character
{
    public string Name { get; }
    public string Role { get; }
    public string Tribe { get; }
    public StatList Stats { get; }
    public Level Level { get; }
    public Inventory Inventory { get; }
    
    public Character(string name, Tribe tribe, Role role,  Inventory inventory)
    {
        Name = name;
        Tribe = tribe.Name.ToString();
        Role = role.Name.ToString();
        Stats = StatListFactory.MergeList([ tribe.Stats, role.Stats ]);
        Level = new Level();
        Inventory = inventory;
    }
}

public static class CharacterFactory
{
    public static Character Create(string name, TribeType tribeType, RoleType roleType)
    {
        var tribe = TribeFactory.Create(tribeType);
        var role = RoleFactory.Create(roleType);
        // TODO: utiliser une facrory pour que en fonction de la classe et du role donnée une arme par defaut
        var inventory = new Inventory(null, null);

        return new Character(name, tribe, role, inventory);
    }
}
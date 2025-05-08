using rpg_gameplay.model.characters.components;
using rpg_gameplay.logic.enums;
namespace rpg_gameplay.logic.factories;

public class RoleFactory 
{
    public static Role Warrior => new(RoleType.Warrior,new StatList(
        new Stat(100, 100),
        new Stat(50, 50),
        new Stat(20),
        new Stat(10),
        new Stat(15),
        new Stat(25),
        new Stat(10),
        new Stat(5),
        new Stat(5)
    ));

    public static Role Rogue => new(RoleType.Rogue,new StatList(
        new Stat(80, 80),
        new Stat(40, 40),
        new Stat(15),
        new Stat(10),
        new Stat(20),
        new Stat(15),
        new Stat(25),
        new Stat(5),
        new Stat(10)
    ));

    public static Role Arcanist => new(RoleType.Arcanist,new StatList(
        new Stat(60, 60),
        new Stat(100, 100),
        new Stat(10),
        new Stat(20),
        new Stat(10),
        new Stat(5),
        new Stat(15),
        new Stat(25),
        new Stat(5)
    ));

    public static Role Clerc => new(RoleType.Clerc,new StatList(
        new Stat(70, 70),
        new Stat(80, 80),
        new Stat(10),
        new Stat(15),
        new Stat(10),
        new Stat(5),
        new Stat(20),
        new Stat(20),
        new Stat(10)
    ));

    public static Role Create(RoleType type) => type switch
    {
        RoleType.Warrior => Warrior,
        RoleType.Rogue => Rogue,
        RoleType.Arcanist => Arcanist,
        RoleType.Clerc => Clerc,
        _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
    };

    public static IEnumerable<Role> GetAll() => new[]
    {
        Warrior, Rogue, Arcanist, Clerc
    };
}

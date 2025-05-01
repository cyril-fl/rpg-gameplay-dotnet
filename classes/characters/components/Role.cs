namespace rpg_gameplay.classes.characters.components;

public enum RoleType
{
    Warrior,
    Thief,
    Mage,
    Healer
}

public class Role : Archetype<RoleType>
{
    public Role(RoleType type, StatList stats)
        : base(type, stats)
    { }
}

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

    public static Role Thief => new(RoleType.Thief,new StatList(
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

    public static Role Mage => new(RoleType.Mage,new StatList(
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

    public static Role Healer => new(RoleType.Healer,new StatList(
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
        RoleType.Thief => Thief,
        RoleType.Mage => Mage,
        RoleType.Healer => Healer,
        _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
    };

    public static IEnumerable<Role> GetAll() => new[]
    {
        Warrior, Thief, Mage, Healer
    };
}

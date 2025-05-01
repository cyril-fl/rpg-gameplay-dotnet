namespace rpg_gameplay.classes.characters.components;

public enum TribeType
{
    Human,
    Elf,
    Orc,
    Dwarf
}
public class Tribe: Archetype<TribeType> {
    public Tribe(TribeType type, StatList stats)
        : base(type, stats)
    { }
}

public class TribeFactory 
{
    public static Tribe Elf => new(TribeType.Elf, new StatList(
        new Stat(80, 80), // HP
        new Stat(40, 40), // MP
        new Stat(15),     // STR
        new Stat(10),     // INT
        new Stat(20),     // AGI
        new Stat(15),     // CON
        new Stat(25),     // DEX
        new Stat(5),      // WIS
        new Stat(10)      // CHA
    )

    );

    public static Tribe Human => new(TribeType.Human, new StatList(
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

    public static Tribe Orc => new (TribeType.Orc, new StatList(
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

    public static Tribe Dwarf => new (TribeType.Dwarf, new StatList(
        new Stat(70, 70),
        new Stat(80, 80),
        new Stat(10),
        new Stat(15),
        new Stat(10),
        new Stat(5),
        new Stat(20),
        new Stat(25),
        new Stat(10)
    ));

        public static Tribe Create(TribeType type) => type switch
    {
        TribeType.Elf => Elf,
        TribeType.Human => Human,
        TribeType.Orc => Orc,
        TribeType.Dwarf => Dwarf,
        _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
    };

    public static IEnumerable<Tribe> GetAll() => new[]
    {
        Elf, Human, Orc, Dwarf
    };
}

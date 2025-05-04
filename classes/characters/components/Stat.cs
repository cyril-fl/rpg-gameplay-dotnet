namespace rpg_gameplay.classes.characters.components;
public enum StatName
{
    Mp, // Health Points
    Str, // Mana Points
    Int, // Strength
    Agi, // Intelligence
    Con, // Agility
    Dex, // Constitution
    Wis, // Dexterity
    Cha, // Wisdom
    Hp // Charisma
}
public class Stat
{
    public int BaseValue { get; set; }
    public int? MaxValue { get; }
    public List<int> Modifiers { get; set; } = new();

    public int Value
    {
        get
        {
            var total = BaseValue + Modifiers.Sum();
            return MaxValue.HasValue ? Math.Min(total, MaxValue.Value) : total;
        }
    }

    public Stat(int baseValue, int? maxValue = null)
    {
        BaseValue = baseValue;
        MaxValue = maxValue;
    }

}
 
public class StatEffect
{
    public StatName StatName { get; }
    public int Modifiers { get; }

    public StatEffect(StatName statName, int modifiers)
    {
        StatName = statName;
        Modifiers = modifiers;
    }
}

public class StatList {
    public Stat Mp { get; set; }
    public Stat Str { get; set; }
    public Stat Int { get; set; }
    public Stat Agi { get; set; }
    public Stat Con { get; set; }
    public Stat Dex { get; set; }
    public Stat Wis { get; set; }
    public Stat Cha { get; set; }
    public Stat Hp { get; set; }

    public StatList(
        Stat hp,
        Stat mp,
        Stat str,
        Stat intel,
        Stat agi,
        Stat con,
        Stat dex,
        Stat wis,
        Stat cha
    )
    {
       Hp = hp;
       Mp = mp;
       Str = str;
       Int = intel;
       Agi = agi;
       Con = con;
       Dex = dex;
       Wis = wis;
       Cha = cha;
    }
    
}

public static class StatListFactory
{
    public static StatList MergeList(List<StatList> sources)
    {
        StatList merged = new StatList(
            Merge([.. sources.Select(s => s.Mp)]),
            Merge([.. sources.Select(s => s.Str)]),
            Merge([.. sources.Select(s => s.Int)]),
            Merge([.. sources.Select(s => s.Agi)]),
            Merge([.. sources.Select(s => s.Con)]),
            Merge([.. sources.Select(s => s.Dex)]),
            Merge([.. sources.Select(s => s.Wis)]),
            Merge([.. sources.Select(s => s.Cha)]),
            Merge([.. sources.Select(s => s.Hp)])
        )
        {

        };
        
        return merged;
    }

    private static Stat Merge(List<Stat> stats)
    {
        int baseValue = stats.Sum(s => s.BaseValue);
        int? maxValue = stats.Any(s => s.MaxValue.HasValue)
            ? stats.Sum(s => s.MaxValue ?? 0)
            : null;

        var merged = new Stat(baseValue, maxValue);

        foreach (var stat in stats)
        {
            merged.Modifiers.AddRange(stat.Modifiers);
        }

        return merged;
    }
}
using  rpg_gameplay.logic.enums;
namespace rpg_gameplay.model.characters.components;

public struct Stat
{
    private int BaseValue { get; set; }
    public int? MaxValue { get; }
    public List<int> Modifiers { get; set; } = new();

    public int Value
    {
        get
        {
            var total = BaseValue + Modifiers.Sum();
            return MaxValue.HasValue ? Math.Min(total, MaxValue.Value) : total;
        }
        set => BaseValue = value;
    }

    public Stat(int baseValue, int? maxValue = null)
    {
        BaseValue = baseValue;
        MaxValue = maxValue;
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

using rpg_gameplay.logic.enums;

namespace rpg_gameplay.model.inventory.components;

public class Effect
{
    public StatName StatName { get; }
    public int Modifiers { get; }

    public Effect(StatName statName, int modifiers)
    {
        StatName = statName;
        Modifiers = modifiers;
    }
}
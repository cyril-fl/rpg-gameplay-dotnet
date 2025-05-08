using rpg_gameplay.logic.enums;
namespace rpg_gameplay.model.characters.components;

public class Tribe: Archetype<TribeType> {
    public Tribe(TribeType type, StatList stats)
        : base(type, stats)
    { }
}


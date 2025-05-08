using rpg_gameplay.logic.enums;
namespace rpg_gameplay.model.characters.components;

public class Role : Archetype<RoleType>
{
    public Role(RoleType type, StatList stats)
        : base(type, stats)
    { }
}
using rpg_gameplay.logic.enums;
using rpg_gameplay.model.world.components;
namespace rpg_gameplay.assets.locations;

public class Town
{
    public static Location FirstTown { get; } = new Location(
        "First Town",
        "A small town with a few houses and a tavern.",
        Biome.Village,
        []
    );

}
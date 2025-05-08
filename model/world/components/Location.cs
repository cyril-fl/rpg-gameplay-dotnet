using rpg_gameplay.logic.enums;
namespace rpg_gameplay.model.world.components;

public class Location
{
    public string Name { get; }
    public string Description { get; } 
    public Biome Biome { get; }

    public List<Legend> Map { get; }


    public Location(string name, string description, Biome biome, List<Legend> map)
    {
        Name = name;
        Description = description;
        Biome = biome;
        Map = map;
    }

}
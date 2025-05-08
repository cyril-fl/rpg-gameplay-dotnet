using rpg_gameplay.assets.locations;
using rpg_gameplay.model.characters;
using rpg_gameplay.model.world.components;
namespace rpg_gameplay.model.world;

public class World {
    public int Day { get; set; }
    public int Time { get; set; }
    public Location Location { get; set; }    // TODO Trouver un meilleur moyen de gerer le monde et ses differentes zones
    public List<string> Log { get; set; } // TODO faire une fonction setLog pour gerer les logs
    public bool IsDay => Time is >= 6 and < 18;
    public Character? Player { get; set; }    // TODO faire un get set pour que au set il ajoute un log
    
    public World()
    {
        Day = 0;
        Time = 0;
        Location =Town.FirstTown;
        Log = new List<string>();
    }
}
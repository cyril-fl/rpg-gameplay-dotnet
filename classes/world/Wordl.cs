using rpg_gameplay.classes.characters;
using rpg_gameplay.classes.world.components;
namespace rpg_gameplay.classes.world;

public class World {

    public int Day { get; set; }
    public int Time { get; set; }
    public Location Location { get; set; }
    public List<string> Log { get; set; }
    public bool IsDay => Time >= 6 && Time < 18;
    public Character? Player { get; set; }
    
    public World(int day, int time, Location location)
    {
        Day = day;
        Time = time;
        Location = location;
        Log = new List<string>();
    }
    
    
}
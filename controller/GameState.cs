using rpg_gameplay.classes.world;

namespace rpg_gameplay.controller;

public class GameState
{
    private static GameState _instance;

    public static GameState Instance => _instance ??= new GameState();

    private GameState() { }

    // public World world { get; set; }

    public void Reset()
    {
        _instance = new GameState();
    }
}
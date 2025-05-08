using rpg_gameplay.model.world;
namespace rpg_gameplay.model;

public sealed class GameState
{
    private static readonly GameState _Instance = new();
    private GameState() { }
    public static GameState Instance => _Instance;
    
    public World? World { get; set; }
}
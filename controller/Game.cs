using rpg_gameplay.model.story;
using rpg_gameplay.model.world;
using  rpg_gameplay.model;


namespace rpg_gameplay.controller;
public static class Game
{
    private static GameState State { get; } = GameState.Instance;
    public static void Start()
    {
        Init();
        Run();
    }

    private static void Init()
    {
        Console.WriteLine("Initializing game...");
        State.World = new World();
    }

    private static void Run()
    {
        Console.WriteLine("Initializing game...");
        var story = new Story();
        story.Play();
    }
}
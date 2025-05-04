using rpg_gameplay.classes.story;

namespace rpg_gameplay.controller;
public static class Game
{
    public static void Start()
    {
        Init();
        Run();
    }

    private static void Init()
    {
        Console.WriteLine("Initializing game...");
     // TODO create Game state
     // Create world    
    }

    private static void Run()
    {
        Console.WriteLine("Initializing game...");
        
        
        var story = new Story();
        story.Play();
    }
}
using rpg_gameplay.classes.story.components;

namespace rpg_gameplay.classes.story;

public class Story
{
    private List<Act> Acts { get; set; } =
    [
        new Act1()
    ];

    public void Play()
    {
        foreach (var act in Acts)
        {
            act.Play();
        }
    }
}
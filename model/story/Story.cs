using rpg_gameplay.assets.story;
using rpg_gameplay.assets.story.components;

namespace rpg_gameplay.model.story;

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
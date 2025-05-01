namespace rpg_gameplay.classes.characters.components;

public class Archetype<T>
{
    public T Name { get; }
    public StatList Stats { get; set; }

     protected Archetype(T name, StatList stats)
    {
        Name = name;
        Stats = stats;
    }
}


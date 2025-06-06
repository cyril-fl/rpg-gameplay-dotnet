using rpg_gameplay.model.characters.components;

namespace rpg_gameplay.model.inventory.components;
public class Potion : Item
{
    public int Duration { get; }
    public List<Effect> Effects { get; } = new();

    public Potion(int id, string name, string description, int rarity, int duration, List<Effect> effects) //int healingAmount
        : base(id, name, description, rarity)
    {
        Duration = duration;
        Effects = effects;
    }

    public void ApplyTo(StatList stats)
    {
        foreach (var effect in Effects)
        {
            var prop = typeof(StatList).GetProperty(effect.StatName.ToString());
            if (prop?.GetValue(stats) is Stat stat)
            {
                stat.Modifiers.Add(effect.Modifiers);
            }

        }
    }
}

/* 
Example :
var strengthPotion = new Potion(
    id: 1,
    name: "Potion of Strength",
    description: "Boosts strength temporarily.",
    rarity: 2,
    duration: 5, // durée en tours, par exemple
    effects: new List<StatEffect>
    {
        new StatEffect("STR", 3)  // ajoute +3 à la force
    }
);

strengthPotion.ApplyTo(heroStats); */
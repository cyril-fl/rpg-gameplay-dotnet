namespace rpg_gameplay.model.characters.components;

public class Level
{
    public int Current { get; private set; } = 1;
    public int Xp { get; private set; } = 0;
    public int XpToNext => 100 * Current;

    public void GainXp(int amount)
    {
        Xp += amount;
        while (Xp >= XpToNext)
        {
            Xp -= XpToNext;
            Current++;
        }
    }
}
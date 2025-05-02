namespace rpg_gameplay.classes.inventory.components;

public class Purse
{
    public int GoldCoin { get; set; }
    public int SilverCoin { get; set; }
    public int CopperCoin { get; set; }
    
    public Purse(int goldCoin, int silverCoin, int copperCoin)
    {
        GoldCoin = goldCoin;
        SilverCoin = silverCoin;
        CopperCoin = copperCoin;
    }
}
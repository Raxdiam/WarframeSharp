namespace WarframeSharp
{
    public interface IDrop
    {
        Rarity Rarity { get; set; }

        double Chance { get; set; }
    }
}
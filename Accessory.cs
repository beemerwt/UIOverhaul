namespace UIOverhaul
{
    public enum AccessoryType
    {
        Belt,
        Trinket,
        Ring,
        Necklace
    }

    public class Accessory
    {
        public AccessoryType Type { get; private set; }

        public Accessory(AccessoryType type)
        {
            Type = type;
        }
    }
}

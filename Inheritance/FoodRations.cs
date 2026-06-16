// FoodRations.cs
public class FoodRations : InventoryItem
{
    public FoodRations() : base(1f, 0.5f)
    {
    }

    public override string ToString()
    {
        return "Ration";
    }
}
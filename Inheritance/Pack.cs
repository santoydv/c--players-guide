public class Pack
{
  private InventoryItem[] _items;
  public int MaxItems { get; }
  public float MaxWeight { get; }
  public float MaxVolume { get; }

  public int CurrentItemCount { get; private set; }
  public float CurrentWeight { get; private set; }
  public float CurrentVolume { get; private set; }

  public Pack(int maxItems, float maxWeight, float maxVolume)
  {
    MaxItems = maxItems;
    MaxWeight = maxWeight;
    MaxVolume = maxVolume;

    _items = new InventoryItem[maxItems];
  }

  public bool Add(InventoryItem item)
  {
    if (CurrentItemCount + 1 > MaxItems)
    {
      return false;
    }

    if (CurrentWeight + item.Weight > MaxWeight)
    {
      return false;
    }

    if (CurrentVolume + item.Volume > MaxVolume)
    {
      return false;
    }

    _items[CurrentItemCount] = item;

    CurrentItemCount++;
    CurrentWeight += item.Weight;
    CurrentVolume += item.Volume;

    return true;
  }

  public override string ToString()
  {
    string contents = "Pack containing";

    for (int i = 0; i < CurrentItemCount; i++)
    {
      contents += " " + _items[i].ToString();
    }

    return contents;
  }
}
public abstract class InventoryItem
{
  public float Weight { get; }
  public float Volume { get; }

  protected InventoryItem(float weight, float volume)
  {
    Weight = weight;
    Volume = volume;
  }
}
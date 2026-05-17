using Classes.Enums;
public class Arrow
{
  private ArrowHeadType _arrowHead;
  private FletchingType _fletching;
  private int _length;

  public Arrow(ArrowHeadType arrowHead, FletchingType fletching, int length)
  {
    _arrowHead = arrowHead;
    _fletching = fletching;
    _length = length;
  }

  // public ArrowHeadType GetArrowHeadType()
  // {
  //   return _arrowHead;
  // }

  // public FletchingType GetFletchingType()
  // {
  //   return _fletching;
  // }

  public ArrowHeadType ArrowHead
  {
    get { return _arrowHead;}
    set { _arrowHead = value;}
  }



  // public int GetLength()
  // {
  //   return _length;
  // }

  public int Length
  {
    get { return _length;}
    set { _length = value;}
  }

  public float GetCost()
  {
    float headCost = 0;
    float fletchingCost = 0;

    // Arrowhead cost
    if (_arrowHead == ArrowHeadType.Steel)
      headCost = 10;
    else if (_arrowHead == ArrowHeadType.Wood)
      headCost = 3;
    else if (_arrowHead == ArrowHeadType.Obsidian)
      headCost = 5;

    // Fletching cost
    if (_fletching == FletchingType.Plastic)
      fletchingCost = 10;
    else if (_fletching == FletchingType.TurkeyFeathers)
      fletchingCost = 5;
    else if (_fletching == FletchingType.GooseFeathers)
      fletchingCost = 3;

    // Shaft cost
    float shaftCost = _length * 0.05f;
    return headCost + fletchingCost + shaftCost;
  }
}
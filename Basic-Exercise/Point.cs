using System.Dynamic;

public class Point
{
  public float PositionX { get; set; }
  public float PositionY { get; set; }

  public Point()
  {
    PositionX = 0;
    PositionY = 0;
  }

  public Point(float positionX, float positionY)
  {
    PositionX = positionX;
    PositionY = positionY;
  }
}
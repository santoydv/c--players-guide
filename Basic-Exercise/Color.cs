public class Color
{
  public int Red { get; set; }
  public int Green { get; set; }
  public int Blue { get; set; }


  public Color(int red, int green, int blue)
  {
    Red = red;
    Green = green;
    Blue = blue;
  }

  public static Color White => new Color(255, 255, 255);
  public static Color Black => new Color(0, 0, 0);
  public static Color RedColor => new Color(255, 0, 0);
  public static Color Orange => new Color(255, 165, 0);
  public static Color Yellow => new Color(255, 255, 0);
  public static Color GreenColor => new Color(0, 128, 0);
  public static Color BlueColor => new Color(0, 0, 255);
  public static Color Purple => new Color(128, 0, 128);
}
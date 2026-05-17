public class Rectangle
{
  private float _length;
  private float _width;

  public Rectangle(float length, float width)
  {
    _length = length;
    _width = width;
  }

  public float Length
  {
    get { return _length;}
    set { _length = value;}
  }

    public float Width
  {
    get { return _width;}
    set { _width = value;}
  }

  public float Area
  {
    get { return _length * _width;}
  }
}
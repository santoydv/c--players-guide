public class Student
{
  private static int _totalStudents;
  private string _name;
  private int _age;

  public Student()
  {
    _totalStudents++;
    _name = "default";
    _age = 15;
  }

  public static int TotalStudents
  {
    get { return _totalStudents;}
  }
}
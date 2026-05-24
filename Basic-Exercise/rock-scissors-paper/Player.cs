using System.Runtime.CompilerServices;

public class Player
{
  public string Name { get; }
  public int Wins { get; private set; }
  public Move CurrentMove { get; set; }

  public Player(string name)
  {
    Name = name;
    Wins = 0;
  }

  public void IncreaseWins()
  {
    Wins++;
  }
}
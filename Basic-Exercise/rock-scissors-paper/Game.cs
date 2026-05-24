using System.Security;

public class Game
{
  public Player Player1 { get; }
  public Player Player2 { get; }

  public int TotalRounds { get; private set; }
  public int TotalDraws { get; private set; }

  public Game(Player player1, Player player2)
  {
    Player1 = player1;
    Player2 = player2;
  }

  public string PlayRound()
  {
    TotalRounds++;

    if (Player1.CurrentMove == Player2.CurrentMove)
    {
      TotalDraws++;
      return "Draw!";
    }

    if (
        (Player1.CurrentMove == Move.Rock && Player2.CurrentMove == Move.Scissors) ||
        (Player1.CurrentMove == Move.Scissors && Player2.CurrentMove == Move.Paper) ||
        (Player1.CurrentMove == Move.Paper && Player2.CurrentMove == Move.Rock)
    )
    {
      Player1.IncreaseWins();
      return $"{Player1.Name} wins!";
    }

    Player2.IncreaseWins();
    return $"{Player2.Name} wins!";
  }
}
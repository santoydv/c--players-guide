Console.Write("Enter Player 1 Name: ");
string player1Name = Console.ReadLine();

Console.Write("Enter Player 2 Name: ");
string player2Name = Console.ReadLine();

Player player1 = new Player(player1Name);
Player player2 = new Player(player2Name);

Game game = new Game(player1, player2);

while (true)
{
  Console.WriteLine($"\n--- Round {game.TotalRounds + 1} ---");

  Console.WriteLine($"\n{player1.Name}, choose:");
  Console.WriteLine("0 - Rock");
  Console.WriteLine("1 - Paper");
  Console.WriteLine("2 - Scissors");

  player1.CurrentMove =
      (Move)Convert.ToInt32(Console.ReadLine());

  Console.WriteLine($"\n{player2.Name}, choose:");
  Console.WriteLine("0 - Rock");
  Console.WriteLine("1 - Paper");
  Console.WriteLine("2 - Scissors");

  player2.CurrentMove =
      (Move)Convert.ToInt32(Console.ReadLine());

  string result = game.PlayRound();

  Console.WriteLine($"\nResult: {result}");

  Console.WriteLine("\n--- Scoreboard ---");
  Console.WriteLine($"{player1.Name} Wins: {player1.Wins}");
  Console.WriteLine($"{player2.Name} Wins: {player2.Wins}");
  Console.WriteLine($"Draws: {game.TotalDraws}");
  Console.WriteLine($"Total Rounds: {game.TotalRounds}");
}
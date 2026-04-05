Console.Write("User1, Guess the number?: ");
int exactNumber = int.Parse(Console.ReadLine());
int guessCount = 0;

Console.WriteLine("It's turn for User 2 to guess.");
while (true)
{
  Console.Write("Guess the number, User 2: ");
  int guessedNumber = int.Parse(Console.ReadLine());
  guessCount++;

  if(guessedNumber == exactNumber)
  {
    Console.WriteLine("\n\nWooooooh!, Congratulation you have guessed the number.");
    Console.WriteLine($"You did this in {guessCount} guesses\n");
    break;
  }

  else if(guessedNumber < exactNumber)
  {
    Console.WriteLine("Ooops!, You,ve guessed too low number");
  }

  else
  {
    Console.WriteLine("Ooops!, You,ve guessed too high number");
  }
}
Console.Write("User1, Guess the number?: ");
int exactNumber = int.Parse(Console.ReadLine());

Console.WriteLine("It's turn for User 2 to guess.");
while (true)
{
  Console.Write("Guess the number, User 2: ");
  int guessedNumber = int.Parse(Console.ReadLine());

  if(guessedNumber == exactNumber)
  {
    Console.WriteLine("Wooooooh!, Congratulation you have guessed the number.");
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
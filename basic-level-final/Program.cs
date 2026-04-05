Console.Write("Player 1, how far away from the city do you want to station the Manticore? ");
int manticoreDistance = int.Parse(Console.ReadLine());

int manticoreHealth = 10, cityHealth = 15;
int totalManticoreHealth = 10, totalCityHealth = 15;
int round = 1;

while(manticoreHealth > 0 && cityHealth > 0)
{
  Console.WriteLine("--------------------------------------------------------------------");

  Console.WriteLine($"STATUS: Round: {round} City: {cityHealth}/{totalCityHealth} Manticore: {manticoreHealth}/{totalManticoreHealth}");

  int damage = Damage(round);

  Console.WriteLine($"The cannon is expected to deal {damage} damage this round.");

  Console.Write("Enter desired cannon range: ");
  int desiredRange = int.Parse(Console.ReadLine());

  if(desiredRange == manticoreDistance)
  {
    manticoreHealth -= damage;
    Console.WriteLine("That round was a DIRECT HIT!");
  }

  else if(desiredRange < manticoreDistance)
  {
    Console.WriteLine("That round FELL SHORT of the target.");
  }

  else
  {
    Console.WriteLine("That round OVERSHOT the target.");
  }

  cityHealth--;
  round++;

  Console.WriteLine("--------------------------------------------------------------------");
}

if(manticoreHealth <= 0)
{
  Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
}

else
{
  Console.WriteLine("The city of Consolas has been destroyed! The Manticores has been saved!");
}

int Damage(int round)
{
  if(round % 3 == 0 && round % 5 == 0)
    return 10;
  else if(round % 3 == 0 || round % 5 == 0)
    return 3;
  else
    return 1;
}
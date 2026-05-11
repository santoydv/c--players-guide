using Enumerations;
Chest chest = Chest.Open;

while (true)
{
  Console.Write($"The Chest is {chest}. What do you want to do? ");
  string command = Console.ReadLine();

  if(command == "unlock")
    chest = Chest.Closed;

  else if(command == "open")
    chest = Chest.Open;

  else
    chest = Chest.Locked;
}

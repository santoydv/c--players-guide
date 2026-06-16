Robot robot = new Robot();

for (int i = 0; i < robot.Commands.Length; i++)
{
  Console.WriteLine($"\nSelect Command #{i + 1}:");
  Console.WriteLine("1 - On\n2 - Off\n3 - North\n4 - South\n5 - East\n6 - West");
  Console.Write("Enter choice (1-6): ");

  if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > 6)
  {
    Console.WriteLine("Invalid number! Please choose between 1 and 6.");
    i--;
  }

  CommandOption selectedOption = (CommandOption)choice;

  IRobotCommand command = selectedOption switch
  {
    CommandOption.On => new OnCommand(),
    CommandOption.Off => new OffCommand(),
    CommandOption.North => new NorthCommand(),
    CommandOption.South => new SouthCommand(),
    CommandOption.East => new EastCommand(),
    CommandOption.West => new WestCommand(),
    _ => null
  };

  robot.Commands[i] = command;
}

Console.WriteLine("\n--- Executing Commands ---");
robot.Run();

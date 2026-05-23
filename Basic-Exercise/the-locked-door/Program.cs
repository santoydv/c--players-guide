Console.Write("Enter initial passcode: ");
int passcode = Convert.ToInt32(Console.ReadLine());

Door door = new Door(passcode);

while (true)
{
  Console.WriteLine($"\nCurrent Door State: {door.State}");

  Console.WriteLine("\n1 - Open");
  Console.WriteLine("2 - Close");
  Console.WriteLine("3 - Lock");
  Console.WriteLine("4 - Unlock");
  Console.WriteLine("5 - Change Passcode");
  Console.WriteLine("6 - Exit");
  Console.Write("Choose an action: ");

  int choice = Convert.ToInt32(Console.ReadLine());

  switch (choice)
  {
    case 1:

      if (door.Open())
        Console.WriteLine("Door opened successfully.");
      else
        Console.WriteLine("Cannot open the door.");

      break;

    case 2:

      if (door.Close())
        Console.WriteLine("Door closed successfully.");
      else
        Console.WriteLine("Cannot close the door.");

      break;

    case 3:

      if (door.Lock())
        Console.WriteLine("Door locked successfully.");
      else
        Console.WriteLine("Cannot lock the door.");

      break;

    case 4:

      Console.Write("Enter passcode: ");
      int unlockPasscode = Convert.ToInt32(Console.ReadLine());

      if (door.Unlock(unlockPasscode))
        Console.WriteLine("Door unlocked successfully.");
      else
        Console.WriteLine("Incorrect passcode or door is not locked.");

      break;

    case 5:

      Console.Write("Enter current passcode: ");
      int currentPasscode = Convert.ToInt32(Console.ReadLine());

      Console.Write("Enter new passcode: ");
      int newPasscode = Convert.ToInt32(Console.ReadLine());

      if (door.ChangePasscode(currentPasscode, newPasscode))
        Console.WriteLine("Passcode changed successfully.");
      else
        Console.WriteLine("Incorrect current passcode.");

      break;

    case 6:

      Console.WriteLine("Exiting program...");
      return;

    default:

      Console.WriteLine("Invalid choice.");
      break;
  }
}
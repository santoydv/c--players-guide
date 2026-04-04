using System;

class Program
{
    static void Main()
    {
        // Change window title
        Console.Title = "Defense of Consolas";

        // Ask user input
        Console.Write("Target Row? ");
        int row = int.Parse(Console.ReadLine());

        Console.Write("Target Column? ");
        int col = int.Parse(Console.ReadLine());

        // Compute neighbors
        int north = row - 1;
        int south = row + 1;
        int west = col - 1;
        int east = col + 1;

        // Change text color
        Console.ForegroundColor = ConsoleColor.Green;

        // Display deployment
        Console.WriteLine("Deploy to:");
        Console.WriteLine($"({north}, {col})");
        Console.WriteLine($"({south}, {col})");
        Console.WriteLine($"({row}, {west})");
        Console.WriteLine($"({row}, {east})");

        // Reset color (good practice)
        Console.ResetColor();

        // Play sound
        Console.Beep();
    }
}
Console.Write("Okay, How many statements should I write?: ");
int number = int.Parse(Console.ReadLine());

for(int i = 0; i < number; i++)
{
  Console.WriteLine($"This is {i} number statement");
}

Console.WriteLine("What kind of thing are we talking about?");
string a = Console.ReadLine();
Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
string b = Console.ReadLine();
string c = "of Doom";
string d = "3000";
Console.WriteLine("The " + b + " " + a + " of " + c + " " + d + "!");


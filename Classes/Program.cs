using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
using Classes.Enums;

Console.WriteLine("Choose Arrow Head:");
Console.WriteLine("0 - Steel");
Console.WriteLine("1 - Wood");
Console.WriteLine("2 - Obsidian");

int headInput = Convert.ToInt32(Console.ReadLine());
ArrowHeadType head = (ArrowHeadType)headInput;

// Fletching Choice
Console.WriteLine("\nChoose Fletching:");
Console.WriteLine("0 - Plastic");
Console.WriteLine("1 - Turkey Feathers");
Console.WriteLine("2 - Goose Feathers");

int fletchingInput = Convert.ToInt32(Console.ReadLine());
FletchingType fletching = (FletchingType)fletchingInput;

// Length
Console.WriteLine("\nEnter Arrow Length (60 - 100 cm):");
float length = Convert.ToSingle(Console.ReadLine());

Arrow arrow = new Arrow(head, fletching, Convert.ToInt32(length));
Console.WriteLine($"\n Cost of this arrow is : {arrow.GetCost()}");


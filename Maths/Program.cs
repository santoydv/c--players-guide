int a = 5;
int b = 2;
int result = a / b;
Console.WriteLine(result);

Console.Clear();

Console.WriteLine($"The value of string is : {Math.PI : 0.000}");

Console.BackgroundColor = ConsoleColor.Yellow;
Console.ForegroundColor = ConsoleColor.Black;

Console.Write("Tell me the base of the triangle: ");
float triangleBase = float.Parse(Console.ReadLine());

Console.Write("Tell me the height of the triangle: ");
float triangleHeight = float.Parse(Console.ReadLine());

float triangleArea = (triangleBase*triangleHeight)/2;

Console.WriteLine("The area of Triangle is: "+ triangleArea);

Console.Clear();

Console.WriteLine("Press any key when you're ready to begin.");
Console.ReadKey(false);

using Tuple.Enums;

(string Name, string RollNumber, int Age) student = ("Santosh", "CS0968", 24);
Console.WriteLine($"Name : {student.Name} RollNumber : {student.RollNumber} Age : {student.Age}");

(int, int) a = (1, 2);
(int, int) b = (1, 2);
Console.WriteLine(a == b);
Console.WriteLine(a != b);

var x = (X: 2, Y: 4);
var y = (U: 2, V: 4);
Console.WriteLine(x == y);

Console.WriteLine("Choose Food Type:");
Console.WriteLine("0 - Soup");
Console.WriteLine("1 - Stew");
Console.WriteLine("2 - Gumbo");

int typeInput = Convert.ToInt32(Console.ReadLine());
FoodType type = (FoodType)typeInput;

Console.WriteLine("\nChoose Main Ingredient:");
Console.WriteLine("0 - Mushrooms");
Console.WriteLine("1 - Chicken");
Console.WriteLine("2 - Carrots");
Console.WriteLine("3 - Potatoes");

int ingredientInput = Convert.ToInt32(Console.ReadLine());
MainIngredient ingredient = (MainIngredient)ingredientInput;


Console.WriteLine("\nChoose Seasoning:");
Console.WriteLine("0 - Spicy");
Console.WriteLine("1 - Salty");
Console.WriteLine("2 - Sweet");

int seasoningInput = Convert.ToInt32(Console.ReadLine());
Seasoning seasoning = (Seasoning)seasoningInput;

(FoodType, MainIngredient, Seasoning) soup = (type, ingredient, seasoning);

Console.Write($"\n Your Food combination is: {soup.Item3} {soup.Item2} {soup.Item1}");

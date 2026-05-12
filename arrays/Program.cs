int[] scores = new int[5];
scores = new int[]{1,2,3,4,5};

Console.WriteLine(scores[0]);
Console.WriteLine(scores[^1]);

Console.Write("The scores are: ");
foreach(int score in scores)
{
  Console.Write($"{score} ");
}
Console.WriteLine();

//shorthand method
int Double(int value) => 2 * value;

Console.WriteLine(Double(4));
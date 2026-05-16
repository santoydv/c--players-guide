List<int> score = new List<int> { 1, 2, 3, 4, 5};

foreach(int x in score)
{
  Console.WriteLine(x);
}


List<int> nums = new() { 1, 2, 3 };

var result = nums.Where(x =>
{
    Console.WriteLine($"Checking {x}");
    return x > 1;
});

Console.WriteLine("Before foreach");

foreach (var x in result)
{
    Console.WriteLine(x);
}
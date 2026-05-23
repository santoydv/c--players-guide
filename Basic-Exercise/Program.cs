//this is for first exercise the point one
// Point p1 = new Point(2,3);
// Point p2 = new Point(-4,0);

// Console.WriteLine($"The first point is (x,y) : ({p1.PositionX},{p1.PositionY})");
// Console.WriteLine($"The first point is (x,y) : ({p2.PositionX},{p2.PositionY})");


//this is for the second exercise, the Color one
// Color custom = new Color(100, 50, 200);

// Color red = Color.RedColor;

// Console.WriteLine("Custom Color:");
// Console.WriteLine($"R: {custom.Red}");
// Console.WriteLine($"G: {custom.Green}");
// Console.WriteLine($"B: {custom.Blue}");

// Console.WriteLine();

// Console.WriteLine("Predefined Red Color:");
// Console.WriteLine($"R: {red.Red}");
// Console.WriteLine($"G: {red.Green}");
// Console.WriteLine($"B: {red.Blue}");

//this is from third exercise, the Card and it's combination for full deck
foreach (CardColor color in Enum.GetValues(typeof(CardColor)))
{
  foreach (CardRank rank in Enum.GetValues(typeof(CardRank)))
  {
    Card card = new Card(color, rank);

    Console.WriteLine($"The {card.Color} {card.Rank}");

    Console.WriteLine($"Number Card: {card.IsNumberCard}");
    Console.WriteLine($"Symbol Card: {card.IsSymbolCard}");

    Console.WriteLine();
  }
}

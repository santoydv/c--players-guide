using System.Drawing;

public class Card
{
  public CardColor Color { get; set; }
  public CardRank Rank { get; set; }

  public Card(CardColor color, CardRank rank)
  {
    Color = color;
    Rank = rank;
  }

  public bool IsNumberCard
  {
    get
    {
      return Rank <= CardRank.Ten;
    }
  }

  public bool IsSymbolCard
  {
    get
    {
      return !IsNumberCard;
    }
  }
}
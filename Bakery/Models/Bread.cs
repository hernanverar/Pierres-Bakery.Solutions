using System;


namespace Bakery.Models
{
  public class Bread

  {
    public int numLoafs { get; set; }

    public Bread(int bread)
    {
      numLoafs = bread;
    }

    public int CalculationBreadPrice() 
    {
      int price = 0;
      if (numLoafs % 2 == 0)
      {
        price = (numLoafs / 2) * 5; 
      }
      else
      {
        price = (numLoafs / 2) * 5 + 5;
      }
      return price;
    }
  }
}


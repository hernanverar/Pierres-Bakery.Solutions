using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Pastry 

  {
    public int numPastry { get; set;}

    public Pastry(int Pastry)
    {
      numPastry = Pastry;
    }

    public int CalculationPastryPrice()
    {
      int price = 0;
      if (numPastry % 12 == 0)
      {
        price = (numPastry / 12) * 18;
      }
      else if (numPastry % 3 == 0)
      {
        price = (numPastry / 3) * 5;
      }
      else if (numPastry % 3 == 1) 
      {
        price = (numPastry / 3) * 5 + 2;
      }
      else 
      {
        price = (numPastry / 3) * 5 + 4;
      }
      return price;
    }
  }
}
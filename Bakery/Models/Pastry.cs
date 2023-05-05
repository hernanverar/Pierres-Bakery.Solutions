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
      if(numPastry % 2 == 0)
      {
        price = (numPastry /2) * 5;
      }
      else 
      {
        price = (numPastry /2) * 5 + 5;
      }
      return price;
    }
  }
}
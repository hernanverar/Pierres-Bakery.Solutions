using System;

namespace Bakery.Models;

class Program
{
  static void Main()
  {
    Console.WriteLine("Welcome to Pierres Bakery best Bread and Pastry's in Town");
    Console.WriteLine("What whould you like to order");
    Console.WriteLine("Bread Prices: one loaf of bread cost $5 dollars");
    Console.WriteLine("Bread Deals: buy 2 get 3rd FREE");
    Console.WriteLine("Pastry Prices: Pastry cost $2 dollars");
    Console.WriteLine("Pastry Deals: 3 pastry's for $5dls, 4 pastry's for $7dls, 5 pastry's for $9dls, 6 pastry's for $10dls or 12 pastry's for $18dls");
    Console.WriteLine("How Many loafs of Bread would you like to purchase?");
    Console.WriteLine("Have a nice day!");

    string stringPlaceOrder = Console.ReadLine();
  }
}
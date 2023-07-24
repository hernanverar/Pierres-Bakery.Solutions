using System;

namespace Bakery.Models;

class Program
{
  static void Main()
  {
    Console.Clear();
    Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
    Console.WriteLine("Welcome to Pierres Bakery best Bread and Pastry's in Town");
    Console.WriteLine("What whould you like to order");
    Console.WriteLine("Bread Prices: one loaf of bread cost $5 dollars");
    Console.WriteLine("Bread Deals: buy 2 get 3rd FREE");
    Console.WriteLine("Pastry Prices: Pastry cost $2 dollars");
    Console.WriteLine("Pastry Deals: 3 pastry's for $5dls, 4 pastry's for $7dls, 5 pastry's for $9dls, 6 pastry's for $10dls or 12 pastry's for $18dls");
    Console.WriteLine("How Many loafs of Bread would you like to purchase?");
    Console.WriteLine("Whould you like to place an order?");
    Console.WriteLine("Yes or No?");
    string stringBeginOrder = Console.ReadLine();
      if (stringBeginOrder == "yes" || stringBeginOrder == "Yes" || stringBeginOrder == "y" || stringBeginOrder == "Y")
      {
        BeginOrder();
      } 
    else 
      {
        Console.WriteLine("Come back soon!");
      }
  }
  static void BeginOrder()
  {
    Console.Clear();
    Console.WriteLine("What would you like to order?");
    Console.WriteLine("'Bread' or 'Pastry'");
    string stringOrderType = Console.ReadLine();
    if (stringOrderType == "Bread" || stringOrderType == "bread")
      {
        PlaceBreadOrder();
      } 
    else if (stringOrderType == "Pastry" || stringOrderType == "pastry") 
      {
        PlacePastryOrder();
      }
    else 
      {
        Console.WriteLine("Please type either 'Bread' or 'Pastry'");
        BeginOrder();
      }
  }
  
  static void PlaceBreadOrder()
  {
    Console.WriteLine("Awesome, loaves are $5 or buy 2 get one free!");
    Console.WriteLine("How many loaves of bread would you like to order?");
    string stringBreadOrderQty = Console.ReadLine();
    int breadOrderQty = int.Parse(stringBreadOrderQty);
    Bread breadOrder = new Bread(breadOrderQty);
    ConfirmOrEditBreadOrder(breadOrder);
  }

  static void ConfirmOrEditBreadOrder(Bread breadOrder)
  {
    Console.WriteLine("Does your order look correct?");
    Console.WriteLine($"Order: {breadOrder.BreadQty} loaves of bread for ${breadOrder.BreadOrderPrice}.");
    Console.WriteLine("Is that correct? Enter 'yes' to proceed, or 'no' to re-enter your bread order");
    string breadOrderCheckInput = Console.ReadLine();
    if (breadOrderCheckInput == "yes" || breadOrderCheckInput == "YES" || breadOrderCheckInput == "Yes" || breadOrderCheckInput == "y" || breadOrderCheckInput == "Y")
    {
      Console.WriteLine("Order Confirmed!");
      Console.WriteLine("Would you like to order some pastries too?");
      string addPastryToBreadOrder = Console.ReadLine();
      if (addPastryToBreadOrder == "yes" || addPastryToBreadOrder == "YES" || addPastryToBreadOrder == "Yes" || addPastryToBreadOrder == "y" || addPastryToBreadOrder == "Y")
      {
        PlacePastryOrder();
      }
      else
      {
        Console.WriteLine("Order Placed!");
        Console.WriteLine("It will be ready shortly");
        Console.WriteLine("Thank you and have a great day!");
      }
    }
    else 
    {
      PlaceBreadOrder();
    }
  }
    static void PlacePastryOrder()
  {
    Console.WriteLine("Great, pastries are $2 or buy 3 get one free!");
    Console.WriteLine("How many pastries would you like to order?");
    string stringPastryOrderQty = Console.ReadLine();
    int PastryOrderQty = int.Parse(stringPastryOrderQty);
    Pastry pastryOrder = new Pastry(PastryOrderQty);
    ConfirmOrEditPastryOrder(pastryOrder);
  }
static void ConfirmOrEditPastryOrder(Pastry pastryOrder)
  {
    Console.WriteLine("Does your order look correct?");
    Console.WriteLine($"Order: {pastryOrder.PastryQty} pastries for ${pastryOrder.PastryOrderPrice}.");
    Console.WriteLine("Is that correct? Enter 'yes' to proceed, or 'no' to re-enter your pastry order");
    string pastryOrderCheckInput = Console.ReadLine();
    if (pastryOrderCheckInput == "yes" || pastryOrderCheckInput == "YES" || pastryOrderCheckInput == "Yes" || pastryOrderCheckInput == "y" || pastryOrderCheckInput == "Y")
    {
      Console.WriteLine("Order Confirmed!");
      Console.WriteLine("Would you like to order some bread too?");
      string addBreadToPastryOrder = Console.ReadLine();
      if (addBreadToPastryOrder == "yes" || addBreadToPastryOrder == "YES" || addBreadToPastryOrder == "Yes" || addBreadToPastryOrder == "y" || addBreadToPastryOrder == "Y")
      {
        PlaceBreadOrder();
      }
      else
      {
        Console.WriteLine("Order Placed!");
        Console.WriteLine("It will be ready shortly");
        Console.WriteLine("Thank you and have a great day!");
      }
    }
    else 
    {
      PlacePastryOrder();
    }
  }
}
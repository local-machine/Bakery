// user interface logic (responsible for prompting user, gathering user input, calling any methods, & returning info to user)

using System;
using System.Collections.Generic;
using Bakery.Items;

namespace Bakery 
{
  public class Program
  {
    public static void Main()
    {
      Bread wheat = new Bread("Hearty loaf of whole grain goodness", 5, "Buy 2, get 1 free.", 10);

      Pastry croissant = new Pastry("Layer after layer of flaky deliciousness", 2, "Buy 3 for $5.", 5);

      Console.WriteLine("Welcome to Pierre's Bakery");

      List<Bread> Breads = new List<Bread>() { wheat };

      foreach(Bread item in Breads)
      {
        Console.WriteLine("Price per loaf: $" + item.GetUnitPrice());
      }

      List<Pastry> Pastries = new List<Pastry>() { croissant };

      foreach(Pastry item in Pastries)
      {
        Console.WriteLine("Price per pastry: $" + item.GetUnitPrice());
      }

      Console.WriteLine("If you would like to buy bread enter B. If you would like to buy pastries enter P.");
      string buyingCheck = Console.ReadLine();
      if(buyingCheck.ToUpper()== "B")
      {
        Console.WriteLine("Let's get this bread!");
        foreach(Bread item in Breads)
        {
          Console.WriteLine(item.GetDescription());
          Console.WriteLine("Flash Sale Alert: " + item.GetDealDescription());
          Console.WriteLine("Enter the number of loaves you would like to buy: ");
          string stringUnitsPurchasing = Console.ReadLine();
          int unitsPurchasing = int.Parse(stringUnitsPurchasing);
          Console.WriteLine(unitsPurchasing);
        }
      }
      else if(buyingCheck.ToUpper()== "P")
      {
        Console.WriteLine("Let's buy some pastries!");
        foreach(Pastry item in Pastries)
        {
          Console.WriteLine(item.GetDescription());
          Console.WriteLine("Flash Sale Alert: " + item.GetDealDescription());
          Console.WriteLine("Enter the number of pastries you would like to buy: ");
          string stringUnitsPurchasing = Console.ReadLine();
          int unitsPurchasing = int.Parse(stringUnitsPurchasing);
          Console.WriteLine(unitsPurchasing);
        }
      }
    }
  }
}
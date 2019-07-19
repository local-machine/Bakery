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
        Console.WriteLine("Price per loaf: $" + item.UnitPrice);
      }

      List<Pastry> Pastries = new List<Pastry>() { croissant };

      foreach(Pastry item in Pastries)
      {
        Console.WriteLine("Price per pastry: $" + item.UnitPrice);
      }

      int total = 0;

      Console.WriteLine("If you would like to buy bread enter Y. If not, enter N.");
      string breadBuyingCheck = Console.ReadLine();
      if(breadBuyingCheck.ToUpper()== "Y")
      {
        Console.WriteLine("Let's get this bread!");
        foreach(Bread item in Breads)
        {
          Console.WriteLine(item.Description);
          Console.WriteLine("Flash Sale Alert: " + item.DealDescription);
          Console.WriteLine("Enter the number of loaves you would like to buy: ");
          string stringUnitsPurchasing = Console.ReadLine();
          int unitsPurchasing = int.Parse(stringUnitsPurchasing);
          total += item.BreadOrder(unitsPurchasing);
          Console.WriteLine("Your bread total comes to: $" + item.BreadOrder(unitsPurchasing));
        }
      }
      else if(breadBuyingCheck.ToUpper()== "N")
      {
        Console.WriteLine("No bread for you today :(");
      }
      else 
      {
        Console.WriteLine("I'm sorry, we didn't understand that.");
      }

      Console.WriteLine("If you would like to purchase pastries enter Y. If not, enter N.");
      string pastryBuyingCheck = Console.ReadLine();
      if(pastryBuyingCheck.ToUpper()== "Y")
      {
        Console.WriteLine("Let's buy some pastries!");
        foreach(Pastry item in Pastries)
        {
          Console.WriteLine(item.Description);
          Console.WriteLine("Flash Sale Alert: " + item.DealDescription);
          Console.WriteLine("Enter the number of pastries you would like to buy: ");
          string stringUnitsPurchasing = Console.ReadLine();
          int unitsPurchasing = int.Parse(stringUnitsPurchasing);
          total += item.PastryOrder(unitsPurchasing);
          Console.WriteLine("Your pastry total comes to: $" + item.PastryOrder(unitsPurchasing));
        }
      }
      else if(pastryBuyingCheck.ToUpper()== "N")
      {
        Console.WriteLine("No pastries for you today :(");
      }
      else 
      {
        Console.WriteLine("I'm sorry, we didn't understand that.");
      }
      Console.WriteLine("Your total is: $" + total);
      Console.WriteLine("Thank you for shopping at Pierre's Bakery!");
    }
  }
}
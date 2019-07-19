using System;
using System.Collections.Generic;

class Bread
{
  public string Description;
  public int UnitPrice;
  public string DealDescription;
  public int DealPrice;

  public Bread(string description, int unitPrice, string dealDescription, int dealPrice)
  {
    Description = description;
    UnitPrice = unitPrice;
    DealDescription = dealDescription;
    DealPrice = dealPrice;
  }
}
class Pastry
{
  public string Description;
  public int UnitPrice;
  public string DealDescription;
  public int DealPrice;

  public Pastry(string description, int unitPrice, string dealDescription, int dealPrice)
  {
    Description = description;
    UnitPrice = unitPrice;
    DealDescription = dealDescription;
    DealPrice = dealPrice;
  }
}
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

    Console.WriteLine("If you would like to buy bread enter B. If you would like to buy pastries enter P.");
    string buyingCheck = Console.ReadLine();
    if(buyingCheck.ToUpper()== "B")
    {
      Console.WriteLine("Lets buy some bread!");
      foreach(Bread item in Breads)
      {
        Console.WriteLine(item.Description);
        Console.WriteLine("Flash Sale Alert: " + item.DealDescription);
        Console.WriteLine("Enter the number of loaves you would like to buy: ");
        string stringUnitsPurchasing = Console.ReadLine();
        int unitsPurchasing = int.Parse(stringUnitsPurchasing);
        Console.WriteLine(unitsPurchasing);
      }
    }
    else if(buyingCheck.ToUpper()== "P")
    {
      Console.WriteLine("Lets buy some pastries!");
      foreach(Pastry item in Pastries)
      {
        Console.WriteLine(item.Description);
        Console.WriteLine("Flash Sale Alert: " + item.DealDescription);
        Console.WriteLine("Enter the number of pastries you would like to buy: ");
        string stringUnitsPurchasing = Console.ReadLine();
        int unitsPurchasing = int.Parse(stringUnitsPurchasing);
        Console.WriteLine(unitsPurchasing);
      }
    }
    
  }
}
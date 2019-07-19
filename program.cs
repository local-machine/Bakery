using System;
using System.Collections.Generic;

class Bread
{
  public string Description;
  public int UnitPrice;
  public string DealDescription;
  public int DealPrice;
}
class Pastry
{
  public string Description;
  public int UnitPrice;
  public string DealDescription;
  public int DealPrice;

}
public class Program
{
  public static void Main()
  {
    Bread wheat = new Bread();
    wheat.Description = "Whole Grain Goodness Wheat";
    wheat.UnitPrice = 5;
    wheat.DealDescription = "Buy 2, get 1 free.";
    wheat.DealPrice = 10;

    Pastry croissant = new Pastry();
    croissant.Description = "Layer after layer of flaky deliciousness";
    croissant.UnitPrice = 2;
    croissant.DealDescription = "Buy 3 for $5.";
    croissant.DealPrice = 5;

  }
}
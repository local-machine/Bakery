namespace Bakery.Items
{
  class Bread
  {
    public string Description { get; set; }
    public int UnitPrice { get; set; }
    public string DealDescription { get; set; }
    public int DealPrice { get; set; }

    public Bread(string description, int unitPrice, string dealDescription, int dealPrice)
    {
      Description = description;
      UnitPrice = unitPrice;
      DealDescription = dealDescription;
      DealPrice = dealPrice;
    }

    public int BreadOrder(int unitsPurchasing)
    {
      int breadTotal = 0;
      if (unitsPurchasing % 3 == 0)
      {
        breadTotal = (DealPrice * (unitsPurchasing/3));
        return breadTotal;
      }
      else
      {
        breadTotal = (UnitPrice * unitsPurchasing);
        return breadTotal;
      }
    }
  }
}
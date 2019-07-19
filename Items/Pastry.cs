namespace Bakery.Items
{
  class Pastry
  {
    public string Description { get; set; }
    public int UnitPrice { get; set; }
    public string DealDescription { get; set; }
    public int DealPrice { get; set; }

    public Pastry(string description, int unitPrice, string dealDescription, int dealPrice)
    {
      Description = description;
      UnitPrice = unitPrice;
      DealDescription = dealDescription;
      DealPrice = dealPrice;
    }

    public int PastryOrder(int unitsPurchasing)
    {
      int pastryTotal = 0;
      if (unitsPurchasing % 3 == 0)
      {
        pastryTotal = (DealPrice * (unitsPurchasing/3));
        return pastryTotal;
      }
      else
      {
        pastryTotal = (UnitPrice * unitsPurchasing);
        return pastryTotal;
      }
    }
  }
}
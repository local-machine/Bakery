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
      if (unitsPurchasing % 3 == 0)
      {
        return (DealPrice * (unitsPurchasing/3));
      }
      else
      {
        return (UnitPrice * unitsPurchasing);
      }
    }
  }
}
namespace Bakery.Items
{
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

    // public bool WorthBuying(int maxPrice)
    // {
    //   return (Price < maxPrice);
    // }
}
namespace Bakery.Items
{
  class Pastry
  {
    private string _Description;
    private int _UnitPrice;
    private string _DealDescription;
    private int _DealPrice;

    public Pastry(string description, int unitPrice, string dealDescription, int dealPrice)
    {
      _Description = description;
      _UnitPrice = unitPrice;
      _DealDescription = dealDescription;
      _DealPrice = dealPrice;
    }
    public string GetDescription()
    {
      return _Description;
    }

    public int GetUnitPrice()
    {
      return _UnitPrice;
    }

    public string GetDealDescription()
    {
      return _DealDescription;
    }

    public int GetDealPrice()
    {
      return _DealPrice;
    }

    // public bool WorthBuying(int maxPrice)
    // {
    //   return (Price < maxPrice);
    // }
  }
}
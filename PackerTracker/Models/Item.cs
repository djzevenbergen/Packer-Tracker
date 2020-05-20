using System.Collections.Generic;

namespace PackerTracker.Models
{
  public class Item
  {
    public string Name { get; set; }
    public decimal Price { get; set; }
    public bool Purchased { get; set; }
    public decimal Weight { get; set; }
    public string Manufacturer { get; set; }
    public bool Packed { get; set; }
    private static List<Item> _instances = new List<Item> { };

    public Item(string name)
    {
      Name = name;
      _instances.Add(this);
    }
    public Item(string name, string price)
    {
      Name = name;
      Price = decimal.Parse(price);
      _instances.Add(this);
    }
    public Item(string name, string price, bool purchased)
    {
      Name = name;
      Price = decimal.Parse(price);
      Purchased = purchased;
      _instances.Add(this);
    }
    public Item(string name, string price, bool purchased, string weight)
    {
      Name = name;
      Price = decimal.Parse(price);
      Purchased = purchased;
      Weight = decimal.Parse(weight);
      _instances.Add(this);
    }
    public Item(string name, string price, bool purchased, string weight, string manufacturer)
    {
      Name = name;
      Price = decimal.Parse(price);
      Purchased = purchased;
      Weight = decimal.Parse(weight);
      Manufacturer = manufacturer;
      _instances.Add(this);
    }
    public Item(string name, string price, bool purchased, string weight, string manufacturer, bool packed)
    {
      Name = name;
      Price = decimal.Parse(price);
      Purchased = purchased;
      Weight = decimal.Parse(weight);
      Manufacturer = manufacturer;
      Packed = packed;
      _instances.Add(this);
    }

    public static decimal GetTotalCost()
    {
      decimal totalCost = 0;
      foreach (Item i in _instances)
      {
        if (i.Purchased == false)
        {
          totalCost += i.Price;
        }
      }
      return totalCost;
    }

    public static List<Item> GetListForPurchase()
    {
      List<Item> falseList = new List<Item> { };
      foreach (Item i in _instances)
      {
        if (i.Purchased == false)
        {
          falseList.Add(i);
        }
      }
      return falseList;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
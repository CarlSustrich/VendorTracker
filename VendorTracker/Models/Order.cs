using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace VendorTracker.Models;


public class Order
{
  public string Name {get;set;}
  public string Description {get;set;}
  public double Price {get;set;}
  public bool Paid {get;set;} =false;
  public DateTime DatePlaced {get;} 
  public DateTime DateDue {get;set;}
  private static List<Order> _instances = new List<Order> {};
  public static int Indexer {get;set;} =0;
  public int ID {get;}


  public Order(string name, string description, double price, int vendorIndex)
  {
    Name = name;
    Description = description;
    Price = price;
    DatePlaced = DateTime.Today;
    ID = Indexer;
    Order.Indexer ++;
    _instances.Add(this);
    Vendor targetVendor = Vendor.GetAll()[Vendor.Find(vendorIndex)];
    targetVendor.Orders.Add(this);
  }

  public static List<Order> GetAll()
  {
    return _instances;
  }

  public static void ClearAll()
  {
    _instances.Clear();
  }

  public static int Find(int orderID)
  {
    int index = -1;
    foreach(Order item in _instances)
    {
      if(orderID == item.ID)
      {
        index = _instances.IndexOf(item);
      }
    }
    return index;
  }
}

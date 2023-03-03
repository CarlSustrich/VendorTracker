using System;
using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Vendor
  {
    public string Name {get;set;}
    public string Description {get;set;}
    private static List<Vendor> _instances = new List<Vendor> {};
    public static int Indexer {get;set;} =0;
    public int ID {get;}
    // public List<Order> Orders {get;set;}

    public Vendor(string vendorName, string vendorDescription)
    {
      Name = vendorName;
      Description = vendorDescription;
      ID = Indexer;
      Vendor.Indexer ++;
      _instances.Add(this);
      // Orders = new List<Order>{};
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}

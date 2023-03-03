using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
      Order.Indexer = 0;
    }


    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      string name = "test name";
      string description = "test description";
      double price = 3.14;
      Vendor targetVendor = new Vendor(name, description);
      int targetVendorID = targetVendor.ID;

      Order testOrder = new Order(name, description, price, targetVendorID);
  
      Assert.AreEqual(typeof(Order), testOrder.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "test name";
      string description = "test description";
      double price = 3.14;
      Vendor targetVendor = new Vendor(name, description);
      int targetVendorID = targetVendor.ID;

      Order testOrder = new Order(name, description, price, targetVendorID);
      string result = testOrder.Name;
      
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string name = "test name";
      string description = "test description";
      double price = 3.14;
      Vendor targetVendor = new Vendor(name, description);
      int targetVendorID = targetVendor.ID;

      Order testOrder = new Order(name, description, price, targetVendorID);
      string result = testOrder.Description;

      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetPrice_ReturnsPrice_Double()
    {
      string name = "test name";
      string description = "test description";
      double price = 3.14;
      Vendor targetVendor = new Vendor(name, description);
      int targetVendorID = targetVendor.ID;

      Order testOrder = new Order(name, description, price, targetVendorID);
      double result = testOrder.Price;
      
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void GetDatePlaced_ReturnsDatePlaced_DateTime()
    {
      string name = "test name";
      string description = "test description";
      double price = 3.14;
      Vendor targetVendor = new Vendor(name, description);
      int targetVendorID = targetVendor.ID;

      Order testOrder = new Order(name, description, price, targetVendorID);
      DateTime result = testOrder.DatePlaced;
      DateTime desiredResult = DateTime.Today;
      
      Assert.AreEqual(desiredResult, result);
    }

    [TestMethod]
    public void GetId_ReturnsCategoryId_Int()
    {
      string name = "test name";
      string description = "test description";
      double price = 3.14;
      Vendor targetVendor = new Vendor(name, description);
      int targetVendorID = targetVendor.ID;

      Order testOrder = new Order(name, description, price, targetVendorID);
      int result = testOrder.ID;
      int desiredResult = 0;
      
      Assert.AreEqual(desiredResult, result);
    }


    [TestMethod]
    public void GetAll_ReturnsListOfOrders_List()
    {
      string name = "test name";
      string description = "test description";
      double price = 3.14;
      Vendor targetVendor = new Vendor(name, description);
      int targetVendorID = targetVendor.ID;
      Order testOrder = new Order(name, description, price, targetVendorID);

      List<Order> result = Order.GetAll();
      List<Order> desiredResult = new List<Order> {testOrder};
      
      CollectionAssert.AreEqual(desiredResult, result);
    }

    [TestMethod]
    public void Find_ReturnsIndexOfCorrectOrderGivenID_Int()
    {
      string name = "test name";
      string description = "test description";
      double price = 3.14;
      Vendor testVendor = new Vendor(name, description);
      int testVendorID = testVendor.ID;
      Order testOrder = new Order(name, description, price, testVendorID);

      Order result = Order.GetAll()[Order.Find(0)];
      Order desiredResult = Order.GetAll()[0];

      Assert.AreEqual(desiredResult, result);
    }

  }
}

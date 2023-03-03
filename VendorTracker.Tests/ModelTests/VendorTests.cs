using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
      Vendor.Indexer = 0;
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      string name = "test name";
      string description = "test description";
      Vendor newVendor = new Vendor(name, description);

      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "test name";
      string description = "test description";
      Vendor testVendor = new Vendor(name, description);

      string result = testVendor.Name;

      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsCategoryId_Int()
    {
      string name = "test name";
      string description = "test description";
      Vendor testVendor = new Vendor(name, description);

      int result = testVendor.ID;
     
      Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void GetId_IncrementsOnVendorCreate_Int()
    {
      string name = "test name";
      string description = "test description";
      Vendor testVendor = new Vendor(name, description);
      string name2 = "test name2";
      string description2 = "test description2";
      Vendor testVendor2 = new Vendor(name2, description2);

      int result = testVendor2.ID;

      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string name = "test name";
      string description = "test description";
      Vendor testVendor = new Vendor(name, description);
      string name2 = "test name2";
      string description2 = "test description2";
      Vendor testVendor2 = new Vendor(name2, description2);
      List<Vendor> testList = new List<Vendor> { testVendor, testVendor2 };

      List<Vendor> result = Vendor.GetAll();

      CollectionAssert.AreEqual(testList, result);
    }

    [TestMethod]
    public void Find_ReturnsIndexOfCorrectVendorGivenID_Int()
    {
      string name = "test name";
      string description = "test description";
      Vendor testVendor = new Vendor(name, description);
      string name2 = "test name2";
      string description2 = "test description2";
      Vendor testVendor2 = new Vendor(name2, description2);

      Vendor result = Vendor.GetAll()[Vendor.Find(1)];
      Vendor desiredResult = Vendor.GetAll()[1];

      Assert.AreEqual(testVendor2, result);
    }

    [TestMethod]
    public void Find_ReturnsNeg1IfVendorNotFound_Vendor()
    {
      string name = "test name";
      string description = "test description";
      Vendor testVendor = new Vendor(name, description);
      string name2 = "test name2";
      string description2 = "test description2";
      Vendor testVendor2 = new Vendor(name2, description2);

      int desiredResult = -1;
      int result = Vendor.Find(5);

      Assert.AreEqual(desiredResult, result);
    }
    
  }

}

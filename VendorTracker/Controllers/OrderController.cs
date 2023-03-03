using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using VendorTracker.Models;
namespace VendorTracker.Controllers;

public class OrderController : Controller
{

  [HttpGet("/vendor/{vendorID}/order/new")]
  public ActionResult New(int vendorID)
  {
    Vendor targetVendor = Vendor.GetAll()[Vendor.Find(vendorID)];
    return View(targetVendor);
  }

  [HttpPost("/vendor/{vendorID}/order")]
  public ActionResult Create(int vendorID, string name, string description, string price)
  {
    double priceToNum = Convert.ToDouble(price);
    Order newOrder = new Order(name, description, priceToNum, vendorID);
    return Redirect($"/vendor/{vendorID}");
  }

}

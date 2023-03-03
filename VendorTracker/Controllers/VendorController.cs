using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VendorTracker.Models;
namespace VendorTracker.Controllers;

public class VendorController : Controller
{
  [HttpGet("/vendor/new")]
  public ActionResult New()
  { return View(); }
  
  [HttpGet("/vendor")]
  public ActionResult Index()
  {
    List<Vendor> vendorList = Vendor.GetAll();
    return View(vendorList); 
  }

  [HttpPost("/vendor")]
  public ActionResult Create(string name, string description)
  {
    Vendor newVendor = new Vendor(name, description);
    return RedirectToAction("Index");
  }

  [HttpGet("/vendor/{vendorID}")]
  public ActionResult Show(int vendorID)
  {
    Vendor targetVendor = Vendor.GetAll()[Vendor.Find(vendorID)];
    return View(targetVendor);
  }
}

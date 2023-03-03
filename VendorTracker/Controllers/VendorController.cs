using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
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
}

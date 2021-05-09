using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using OrderTracker.Models;

namespace OrderTracker.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
       Vendor vendor = Vendor.Find(vendorId);
       return View(vendor);
    }
  }
}

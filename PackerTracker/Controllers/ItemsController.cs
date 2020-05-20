using Microsoft.AspNetCore.Mvc;
using PackerTracker.Models;
using System.Collections.Generic;

namespace PackerTracker.Controllers
{
  public class ItemsController : Controller
  {
    [HttpGet("/items")]
    public ActionResult Index()
    {
      List<Item> testList = Item.GetListForPurchase();
      return View(testList);
    }

    [HttpGet("/items/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/items")]
    public ActionResult Create(string name, string price, bool purchased, string weight, string manufacturer, bool packed)
    {
      Item newItem = new Item(name, price, purchased, weight, manufacturer, packed);
      return RedirectToAction("Index");
    }
  }
}
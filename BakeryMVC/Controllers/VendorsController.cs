using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using BakeryMVC.Models;

namespace BakeryMVC.Controllers
{
  public class VendorsController : Controller
  {
      [HttpGet("/vendors")]
      public ActionResult Index()
      {
        // List<Vendor> allVendors = Vendor.GetAll();
        return View(); //(allVendors);
      }

      [HttpGet("/vendors/new")]
      public ActionResult New()
      {
        return View();
      }

      // [HttpPost("/vendors")]
      // public ActionResult Create(string vendorName)
      // {
      //   // Vendor newVendor = new Vendor(vendorName);
      //   // return RedirectToAction("Index");
      // }

      // [HttpGet("/vendors/{id}")]
      // public ActionResult Show(int vendorId)
      // {
      //   Dictionary<string, object> model = new Dictionary<string, object>();
      //   Category selectedCategory = Category.Find(vendorId);
      //   List<Item> categoryItems = selectedCategory.Items;
      //   model.Add("category", selectedCategory);
      //   model.Add("items", categoryItems);
      //   return View(model); //View() can only accept one argument
      // } //Displays one specific Category's details

      // [HttpPost("/vendor/{vendorId}/orders")]
      //   public ActionResult Create(int vendorId, string orderDescription)
      //   {
      //     Dictionary<string, object> model = new Dictionary<string, object>();
      //     Category foundCategory = Category.Find(categoryId);
      //     Item newItem = new Item(itemDescription);
      //     foundCategory.AddItem(newItem);
      //     List<Item> categoryItems = foundCategory.Items;
      //     model.Add("items", categoryItems);
      //     model.Add("category", foundCategory);
      //     return View("Show", model);
      //   } //Creates new Item w/in specific Category on server, not new Categories
      // }
  }
}
using Microsoft.AspNetCore.Mvc;
using BakeryMVC.Models;

namespace ToDoList.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Index()
    {
      // Item starterItem = new Item("Add first item to To Do List");
      return View(); // (starterItem);
    }


    [Route("/orders/new")]
    public ActionResult CreateForm()
    {
      return View();
    }


    // [Route("/orders")]
    // public ActionResult Create(string description)
    // {
    //   // Item myItem = new Item(description);
    //   // return View("Index", myItem);
    // }

  }
}

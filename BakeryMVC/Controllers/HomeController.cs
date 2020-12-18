using Microsoft.AspNetCore.Mvc;
using BakeryMVC.Models;

namespace ToDoList.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}

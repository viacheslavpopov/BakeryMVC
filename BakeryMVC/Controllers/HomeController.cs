using Microsoft.AspNetCore.Mvc;

namespace BakeryMVC.Controllers
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

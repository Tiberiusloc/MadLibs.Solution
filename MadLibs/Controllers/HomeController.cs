using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route ("/")]
    public ActionResult Home() {return View();}

    [Route ("/result")]
    public ActionResult Result(string noun, string verb, string adj)
    {
      
    }
  }
}
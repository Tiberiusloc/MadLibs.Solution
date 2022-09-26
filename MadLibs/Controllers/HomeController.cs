using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route ("/")]
    public ActionResult Home() {return View();}

    [Route ("/puppy-story")]
    public ActionResult PuppyForm() {return View();}

    [Route ("/grocery-trip")]
    public ActionResult GroceryForm() {return View();}

    [Route ("/circus-day")]
    public ActionResult CircusForm() {return View();}



    [Route ("/puppy-story2")]
    public ActionResult PuppyResult(string food1, string food2, string food3, string noun, string verb, string adj)
    {
      Words userWords = new Words();
      userWords.FoodName1 = food1;
      userWords.FoodName2 = food2;
      userWords.FoodName3 = food3;
      userWords.Noun = noun;
      userWords.Verb = verb;
      userWords.Adj = adj;

      return View(userWords);
    }

    [Route ("/grocery-story2")]
    public ActionResult GroceryResult(string grandmaName, string food1, string food2, string food3, string noun, string verb, string adj)
    {
      Words userWords = new Words();
      userWords.GrandmaName = grandmaName;
      userWords.FoodName1 = food1;
      userWords.FoodName2 = food2;
      userWords.FoodName3 = food3;
      userWords.Noun = noun;
      userWords.Verb = verb;
      userWords.Adj = adj;

      return View(userWords);
    }
  }
}
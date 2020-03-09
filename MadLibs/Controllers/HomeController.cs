using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    
    [Route("/")]
    public ActionResult Form() { return View(); }


    [Route("/result")]
    public ActionResult Result(string noun1, string noun2, string adjective1, string adjective2, string verb1,string verb2, string adverb)
    {
        Libs newLibs = new Libs();
        newLibs.Noun1 = noun1;
        newLibs.Noun2 = noun2;
        newLibs.Adjective1 = adjective1;
        newLibs.Adjective2 = adjective2;
        newLibs.Verb1 = verb1;
        newLibs.Verb2 = verb2;
        newLibs.Adverb = adverb;
        return View(newLibs);
    }

  }
}
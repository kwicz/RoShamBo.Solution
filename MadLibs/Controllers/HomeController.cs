using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    
    [Route("/")]
    public ActionResult Select() { return View(); }

    [Route("form1")]
    public ActionResult form1() { return View(); }

    [Route("/result1")]
    public ActionResult Result1(string noun1, string noun2, string adjective1, string adjective2, string verb1,string verb2, string adverb)
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

    [Route("DelphiaForm")]
    public ActionResult DelphiaForm() { return View(); }


    [Route("/Delphia")]
    public ActionResult Delphia(string noun1, string noun2, string noun3, string noun4, string noun5, string noun6, string noun7, string noun8, string adjective1, string adjective2, string adjective3, string pastverb,string ingverb)
    {
        Libs newLibs = new Libs();
        newLibs.Noun1 = noun1;
        newLibs.Noun2 = noun2;
        newLibs.Noun3 = noun3;
        newLibs.Noun4 = noun4;
        newLibs.Noun5 = noun5;
        newLibs.Noun6 = noun6;
        newLibs.Noun7 = noun7;
        newLibs.Noun8 = noun8;
        newLibs.Adjective1 = adjective1;
        newLibs.Adjective2 = adjective2;
        newLibs.Adjective3 = adjective3;
        newLibs.PastVerb = pastverb;
        newLibs.IngVerb = ingverb;
        return View(newLibs);
    }
    [Route("/BreakUpForm")]


    [Route("/BreakUpForm")]
  }
}
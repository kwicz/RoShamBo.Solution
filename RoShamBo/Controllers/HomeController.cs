using Microsoft.AspNetCore.Mvc;
using RoShamBo.Models;
using System;

namespace RoShamBo.Controllers
{
  public class HomeController : Controller
  {
    // PlayerNames newPlayers = new PlayerNames();
    
    // Round newRound;
    
    [Route("/")]
    public ActionResult Home() { return View(); }

    [Route("/roundPlayerOne")]
    public ActionResult roundPlayerOne(string playerOneName, string playerTwoName) 
    { 
      Round.P1Name = playerOneName;
      Round.P2Name = playerTwoName;
      return View(); 
    }

    [Route("/roundPlayerTwo")]
    public ActionResult roundPlayerTwo(string playerOneTurn) 
    { 
      
      // newRound = new Round(playerOneTurn);
      Round.P1Hand = playerOneTurn;
      return View(); 
    
    }

    [Route("/Winner")]
    public ActionResult Winner(string playerTwoTurn)
    {
      // string playerOneTurn = newRound.P1Hand;
      // newRound = new Round("rock", playerTwoTurn);
      string winner = Round.WinnerCheck();
      return View();
    }

  }
}
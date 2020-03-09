using Microsoft.AspNetCore.Mvc;
using RoShamBo.Models;
using System;

namespace RoShamBo.Controllers
{
  public class HomeController : Controller
  {
    PlayerNames newPlayers = new PlayerNames();
    Round newRound;
    
    [Route("/")]
    public ActionResult Home() { return View(); }

    [Route("/roundPlayerOne")]
    public ActionResult roundPlayerOne(string playerOneName, string playerTwoName) 
    { 
      newPlayers.P1Name = playerOneName;
      newPlayers.P2Name = playerTwoName;
      return View(newPlayers); 
    }

    [Route("/roundPlayerTwo")]
    public ActionResult roundPlayerTwo(string playerOneTurn) 
    { 
      
      newRound = new Round(playerOneTurn);
      return View(newPlayers); 
    
    }

    [Route("/Winner")]
    public ActionResult Winner(string playerTwoTurn)
    {
      string playerOneTurn = newRound.P1Hand;
      newRound = new Round(playerOneTurn, playerTwoTurn);
      string winner = newRound.WinnerCheck();
      return View(winner);
    }

  }
}
namespace RoShamBo.Models
{
  public class Round
  {
    public static string P1Hand { get; set; }
    public static string P2Hand { get; set; }
    public static string Winner { get; set; }
    public static string P1Name { get; set; }
    public static string P2Name { get; set; }



    // public Round(string player1)
    // {
    //   P1Hand = player1;
    // }
    // public Round(string player1, string player2)
    //   : this(player1)
    // {
    //   P2Hand = player2;
    // }


    public static string WinnerCheck()
    {
      if (P1Hand == P2Hand)
      {
        return "draw";
      }
      else if (P1Hand == "rock" && P2Hand == "scissors" || P1Hand == "scissors" && P2Hand == "paper" || P1Hand == "paper" && P2Hand == "rock")
      {
        return "player 1 wins";
      }
      else
      {
        return "player 2 wins";
      }
    }
  }
}
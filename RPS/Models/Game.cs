using System;

namespace Game.Models
{
  public class GamePlay
  {
    public static string Start(string input, string test)
    {
      //Easter Eggs
      switch (input)
      {
        case "nuke":
          break;
        default:
          break;
      }

      char lowerInput = Char.ToLower(input[0]);
      int playerNumb;

      switch (lowerInput)
      {
        case 'r':
          playerNumb = 0;
          break;
        case 'p':
          playerNumb = 1;
          break;
        case 's':
          playerNumb = 2;
          break;
        default:
          throw new System.InvalidOperationException("ERROR 8876 : Incorrect input string.");
      }
      int computerPlayer = ComputerTurn(test);

      if (Tie(playerNumb, computerPlayer))
      {
        return "Tie Game";
      }
      else
      {
        bool gameState = Compare(playerNumb, computerPlayer);
        if (gameState)
        {
          return "You Win";
        }
        else
        {
          return "Computer Wins";
        }
      }


    }

    public static bool Compare(int player, int computer)
    {
      if (player == 0 && computer == 2)
      {
        return true;
      }
      else if (player == 1 && computer == 0)
      {
        return true;
      }
      else if (player == 2 && computer == 1)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public static bool Tie(int player, int computer)
    {
      if (player == computer)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public static int ComputerTurn(string test)
    {
      if (test == "test")
      {
        return 1;
      }
      else
      {
        Random number = new Random();
        return number.Next(0, 3);
      }
    }
  }

}
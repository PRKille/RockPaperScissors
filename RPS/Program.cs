using System;
using Game.Models;

namespace Game
{
  public class Program
  {
    public static void Main()
    {
      Console.Clear();
      Console.WriteLine(@"
   ______  _____  _______ _     _       _____  _______  _____  _______  ______
  |_____/ |     | |       |____/       |_____] |_____| |_____] |______ |_____/
  |    \_ |_____| |_____  |    \_      |       |     | |       |______ |    \_
                                                                              
              _______ _______ _____ _______ _______  _____   ______
              |______ |         |   |______ |______ |     | |_____/
              ______| |_____  __|__ ______| ______| |_____| |    \_

      ");

      Console.WriteLine("[P] to Play the Champion!!!");
      Console.WriteLine("[E] to Exit the game!!!");
      string startInput = Console.ReadLine().ToLower();

      if (startInput == "e")
      {
        Console.Clear();
        Console.WriteLine(@"
              ______  _____   _____  ______  ______  __   __ _______
             |  ____ |     | |     | |     \ |_____]   \_/   |______
             |_____| |_____| |_____| |_____/ |_____]    |    |______
                                                                    
        ");
      }
      else
      {
        Console.WriteLine(@"
                          ______ _______ _______ _______
                         |  ____ |_____| |  |  | |______
                         |_____| |     | |  |  | |______
                                                        
                  ______  _______  ______ _____ __   _ _______
                  |_____] |______ |  ____   |   | \  | |______
                  |_____] |______ |_____| __|__ |  \_| ______|
                                                              
                                                                    
        ");

        Console.WriteLine("[R] Rock");
        Console.WriteLine("[P] Paper");
        Console.WriteLine("[S] Scissors");
        Console.Write(" Enter : ");
        string input = Console.ReadLine();
        try
        {
          string result = GamePlay.Start(input, startInput);
          Console.WriteLine(result);

        }
        catch (Exception ex)
        {
          Console.WriteLine("Message = {0}", ex.Message);
          Console.WriteLine("Source = {0}", ex.Source);
          Console.WriteLine("StackTrace = {0}", ex.StackTrace);
          Console.WriteLine("TargetSite = {0}", ex.TargetSite);
          Console.WriteLine("\nPress Enter");
          Console.ReadLine();
          Main();
        }

        Console.WriteLine("\nPlay again? [Y] Yes [N] No");
        string playAgain = Console.ReadLine().ToLower();

        try
        {
          switch (playAgain)
          {
            case "y":
              Main();
              break;
            case "n":
              Console.Clear();
              Console.WriteLine(@"
              ______  _____   _____  ______  ______  __   __ _______
             |  ____ |     | |     | |     \ |_____]   \_/   |______
             |_____| |_____| |_____| |_____/ |_____]    |    |______
                                                                    
        ");
              break;
            default:
              throw new System.InvalidOperationException("ERROR 4389 : No Banana Stickers were found.");
          }
        }
        catch (Exception ex)
        {
          Console.WriteLine("Message = {0}", ex.Message);
          Console.WriteLine("Source = {0}", ex.Source);
          Console.WriteLine("StackTrace = {0}", ex.StackTrace);
          Console.WriteLine("TargetSite = {0}", ex.TargetSite);

          Console.WriteLine("\nPress Enter");
          Console.ReadLine();
          Main();


        }

      }
    }

  }

}
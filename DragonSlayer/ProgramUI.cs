using System.Threading.Tasks.Dataflow;
using static System.Console;

public class ProgramUI
{
   private Knight knight = new Knight();

   public void Run()
   {
      RunApplication();
   }

   private void RunApplication()
   {
      bool isRunning = true;
      while (isRunning)
      {
         System.Console.WriteLine("Welcome To Dragon Slayer\n" +
         "1. Start Game\n" +
         "2. End Game\n");

         string userInput = Console.ReadLine();

         switch (userInput)
         {
            case "1":
               StartGame();
               break;

            case "2":
               isRunning = EndGame();
               break;

            case "3":
            KnightMove();
            break; 

            default:
               System.Console.WriteLine("Invalid selection. Please try again!");
               break;
         }
      }
   }

   private void StartGame() //Method to begin playing the game
   {
      Clear();
      while (knight.IsAlive) //Checks to see if Knight is alive
      {
         WriteLine("Welcome to your journey!");
        WriteLine("The princess has been taken by a dragon... Survive the 3 castle levels reach the dragon to save the princess!!");
         WriteLine("Press any key to open the castle doors");
         ReadKey(); 
         

      }

      // else {
      //    if  (knight.Points = 0) {
      //       WriteLine("You're DEAD! You lost all your armor. Better luck next time!");
      //       EndGame();
      //    }

      // }





      ReadKey();
   }
   private bool EndGame() //Method that ends the game
   {
      PressAnyKey();
      return false;
   }

   private void PressAnyKey() //Method to read key inputs
   {
      System.Console.WriteLine("Press any key to continue");
      ReadKey();

   }

   private void KnightMove() {
      Console.Clear();
      WriteLine("You open the door and you see two paths, left and straight. Choose a path. \n" 
      + "1. left \n" 
      + "2. straight");
   }
}





/*
princess in a castle...
the princess has been taken by a dragon...
right, left, up, back
3 levels...
knight dies if points are less then or equal to 0.

base level -> 200 point armor and weapons
   -> gains armor and weapons points as he goes
   -> by end 2000 points must be needed to kill dragon or he dies

level 1
   -> 200 points to start + level 1 treasure chest = 250 points
   finish 1 level = 450 points at first level
   -> wizard -> option 1 - 500 points
            + option 2 sword upgrade 100 points
            + option 3 -200 points
   -> level one deadend chest 200 points

level 2
   -> chest 500 points
   -> level 2 deadend chest 400 points

level 3
   -> chest 1000 points
   -> you fight the dragon - points less then 2000 death it swallows you.
                           - points greater then 2000 you behead the dragon with sword

final
-> max total points you can get marry the princess and become king
-> if then she throws you a party and say thanks and goodbye.
*/
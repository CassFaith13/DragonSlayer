using static System.Console;

public class ProgramUI {
   private Knight knight = new Knight();
   public int Points = 200;


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

         string? userInput = Console.ReadLine();

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
    //   while (knight.IsAlive) //Checks to see if Knight is alive
    //   {
      WriteLine("Welcome to your journey!");
      WriteLine("The princess has been taken by a dragon...You're a knight of the Round Table and you must SAVE HER! \n"
      + "Survive the 3 castle levels to reach the dragon. Defeat the dragon to save the princess!!");
      WriteLine("Press any key to open the castle doors");
      ReadKey();
      KnightMove();
        //   }

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

      string? input = Console.ReadLine();

      switch (input)
      {
         case "1":
         System.Console.WriteLine("You turn left. You reach another two paths.");
         FirstMove();
         break;
         case "2":
         System.Console.WriteLine("You walk straight. There is a long dark hallway. You walked to a dead end. Turn back!");
         KnightMove();
         break;
         default:
         System.Console.WriteLine("Invalid selection. Please try again!");
         break;
      }
    // switch case with dead end and new first move method.
   }

   private void FirstMove() 
   {
      System.Console.WriteLine("You have reached two paths: straight and right. Choose a path.\n"
      + "1. straight\n"
      + "2. right");

      string? input = Console.ReadLine();
      
      switch (input)
      {
         case "1":
         System.Console.WriteLine("You walk straight ahead. There is a brick wall. Turn back!");
         FirstMove();
         break;
         case "2":
         System.Console.WriteLine("You turn right. You walk down a long dark hallway. You finally reach the end and come onto two paths.");
         SecondMove();
         break;
         default:
         System.Console.WriteLine("Invalid selection. Please try again!");
         break;
      }
   }

   private void SecondMove()
   {
      System.Console.WriteLine("You have reached two paths: straight and right. Choose a path.\n"
      + "1. straight\n"
      + "2. right");

      string? input = Console.ReadLine();
      
      switch (input)
      {
         case "1":
         System.Console.WriteLine("You walk straight ahead. It's a dead end. Turn back!");
         SecondMove();
         break;
         case "2":
         System.Console.WriteLine("You turn right. There is a stairway. You walk up the stairs. CONGRATULATIONS! You've made it to LEVEL TWO. There is something shiny...");
         ThirdMove();
         break;
         default:
         System.Console.WriteLine("Invalid selection. Please try again!");
         break;
      }
   }

   private void ThirdMove()
   {
      System.Console.WriteLine("At the top of the staircase you see a bright gold treasure chest!!! You have received 250 points!");
      Points= Points + 250;
      System.Console.WriteLine("You now have " + Points + " points!");
      System.Console.WriteLine("Now you see there are two paths ahead: left and right. Choose a path.\n"
      + "1. left\n"
      + "2. right");

      string? input = Console.ReadLine();

      switch (input)
      {
         case "1":
         System.Console.WriteLine("You turn left. There is nothing there but cobwebs. Turn back! \n"
         + "Once you turn back you take the other path.");
          FourthMove();
         break;
         case "2":
         System.Console.WriteLine("You turn right. You go around a hallway with some twists and turns. You reach another two paths.");
            FourthMove();
            break;
            default:
            System.Console.WriteLine("Invalid selection. Please try again!");
            break;
      }
   }

   private void FourthMove() 
   {
      System.Console.WriteLine("Now you see there are two paths ahead: left and right. Choose a path.\n"
      + "1. left\n"
      + "2. right");

      string? input = Console.ReadLine();

      switch (input)
      {
         case "1":
         System.Console.WriteLine("You turn left.");
         ChestDeadMove();
         break;
         case "2":
         System.Console.WriteLine("You turn right. After walking down a hall you come upon a man blocking your path.");
            FifthMove();
            break;
            default:
            System.Console.WriteLine("Invalid selection. Please try again!");
            break;
      }
   }

   private void ChestDeadMove() 
   {
      System.Console.WriteLine("After taking some turn you find a door covered in blood. Shall you go in or turn back... \n"
      + "1. Open the door...\n"
      + "2. Turn around and leave");

      string? input = Console.ReadLine();

      switch (input)
      {
         case "1":
         System.Console.WriteLine("You find a Chest and gain 200 points! ");
         Points= Points + 200;
         System.Console.WriteLine("You now have " + Points + " points!\n"
         + "Seeing there are no other paths you go back the way you came and take the other path.");
         FifthMove();
         break;
         case "2":
         System.Console.WriteLine("You go back and take the other path... After walking down a hall you come upon a man blocking your path.");
            FifthMove();
            break;
            default:
            System.Console.WriteLine("Invalid selection. Please try again!");
            break;
      }
   }

   private void FifthMove() 
   {
      System.Console.WriteLine("Wizard: Hello, pick a box and I will let you through.\n"
      + "1. box 1 \n"
      + "2. box 2 \n"
      + "3. box 3");

      string? input = Console.ReadLine();

      switch (input)
      {
         case "1":
         System.Console.WriteLine("Sorry, I must take 500 points. ");
        Points= Points - 500;
        System.Console.WriteLine("You now have " + Points + " points");
          // add -500 points deduction - for most that means death
         SixthMove();
         break;
         case "2":
         System.Console.WriteLine("You found the holy sword worth 100 points. ! Let it aid you on your quest! ");
         Points= Points + 100;
         System.Console.WriteLine("You now have " + Points + " points");
         // add +100 points 
         SixthMove();
         break;
         case "3":
         System.Console.WriteLine("Sorry, I must take 200 points.");
         Points= Points - 200;
         System.Console.WriteLine("You now have " + Points + " points!");
          // add -200 points deduction
         FourthMove();
         break;
            default:
            System.Console.WriteLine("Invalid selection. Please try again!");
            break;
      }
   }

  private void SixthMove()
   {
      System.Console.WriteLine("You have reached two paths: straight and right. Choose a path.\n"
      + "1. left\n"
      + "2. right\n"
      + "3. straight");

      string? input = Console.ReadLine();
      
      switch (input)
      {
         case "1":
         System.Console.WriteLine("You walk left ahead. It's a dead end. Turn back!");
         SixthMove();
         break;
          case "2":
         System.Console.WriteLine("You walk right ahead. It's a dead end. Turn back!");
         SixthMove();
         break;
         case "3":
         System.Console.WriteLine("You got straight. There is a stairway. You walk up the stairs. CONGRATULATIONS! You've made it to LEVEL THREE. There is something shiny...");
          SixthMove();
         // SeventhMove();
         break;
         default:
         System.Console.WriteLine("Invalid selection. Please try again!");
         break;
      }
   }




    // switch cases going through castle

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
   -> level one dead end chest 200 points

level 2
   -> chest 500 points
   -> level 2 dead end chest 400 points

level 3
   -> chest 1000 points
   -> you fight the dragon - points less then 2000 death it swallows you.
                           - points greater then 2000 you behead the dragon with sword

final
-> max total points you can get marry the princess and become king
-> if then she throws you a party and say thanks and goodbye.
*/
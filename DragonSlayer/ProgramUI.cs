using static System.Console;

public class ProgramUI 
{
   private Knight knight = new Knight();
   public int Points; //It was not starting with 200 points, but need this to use Points.


   public void Run()
   {
      RunApplication();
   }

   private void RunApplication()
   {
      bool isRunning = true;

      while (isRunning)
      {
         WriteLine("\n"
         + "Welcome To Dragon Slayer!\n"
         + "\n"
         + "1. Start Game\n" 
         + "2. End Game\n");

         string? userInput = ReadLine();

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
            WriteLine("Invalid selection. Please try again!");
            break;
            }
      }
   }

   private void StartGame() //Method to begin playing the game
   {
      Clear();
      WriteLine("Welcome to your journey!\n"
      + "");
      Points = 200; //Moved points here to have 200 points start with each game.
      WriteLine("The princess has been taken by an evil dragon...You're a knight of the Round Table and you MUST SAVE HER!\n"
      + "Survive the 3 castle levels to reach the Tower where the princess is being held. Defeat the dragon to save the princess!\n"
      + "\n"
      + "Choose a direction to move through the castle. Gain as many armor points as you can along the way. Make good choices because a wrong move could be costly.");
      WriteLine("Press any key to open the castle doors.");
      ReadKey();
      KnightMove();
      ReadKey();
   }

   private bool EndGame() //Method that ends the game
   {
      PressAnyKey();
      Points = 0; //If you died or restarted the game you would continue racking up points even after defeating the dragon.
      return false;
   }

   private void PressAnyKey() //Method to read key inputs
   {
      WriteLine("Press any key to continue.");
      ReadKey();
   }

   private void KnightMove() 
   {
      WriteLine("\n" //Adding a blank line for better readability
      + "You open the castle door and you see two paths in front of you: left and straight. Choose a path.\n" 
      + "1. Left\n" 
      + "2. Straight");

      string? input = ReadLine();

      switch (input)
      {
         case "1":
         WriteLine("You turn left. Immediately you see another two paths in front of you.");
         FirstMove();
         break;
         case "2":
         WriteLine("You walk straight ahead. There is a long dark hallway. You walked into a dead end. Turn back!");
         KnightMove();
         break;
         default:
         WriteLine("Invalid selection. Please try again!");
         break;
      }
   }

   private void FirstMove() 
   {
      WriteLine("\n"
      + "The two paths in front of you are straight and right. Choose a path.\n"
      + "1. Straight\n"
      + "2. Right");

      string? input = ReadLine();
      
      switch (input)
      {
         case "1":
         WriteLine("You walk straight ahead. There is a nothing but a brick wall. Turn back!");
         FirstMove();
         break;
         case "2":
         WriteLine("You turn right. You walk down a long dark hallway. You finally reach the end and come onto two paths.");
         SecondMove();
         break;
         default:
         WriteLine("Invalid selection. Please try again!");
         break;
      }
   }

   private void SecondMove()
   {
      WriteLine("\n"
      + "The two paths you reached are straight and right. Choose a path.\n"
      + "1. Straight\n"
      + "2. Right");

      string? input = ReadLine();
      
      switch (input)
      {
         case "1":
         WriteLine("You walk straight ahead. It's a dead end. Turn back!");
         SecondMove();
         break;
         case "2":
         ForegroundColor = ConsoleColor.Blue;
         WriteLine("You turn right. There is a long red stairway. You walk up the stairs. CONGRATULATIONS!!! You've made it to LEVEL TWO. There is something shiny up ahead...");
         ResetColor();
         ThirdMove();
         break;
         default:
         WriteLine("Invalid selection. Please try again!");
         break;
      }
   }

   private void ThirdMove()
   {
      ForegroundColor = ConsoleColor.Yellow;
      WriteLine("\n"
      + "As you reach the top of the staircase you see a bright gold treasure chest!!! You have received 250 armor points!");
      Points = Points + 250;
      WriteLine("You now have " + Points + " armor points!");
      ResetColor();
      WriteLine("Now you see there are two paths ahead: left and right. Choose a path.\n"
      + "1. Left\n"
      + "2. Right");

      string? input = ReadLine();

      switch (input)
      {
         case "1":
         WriteLine("You turn left. There is nothing there but cobwebs. Turn back! \n"
         + "You turn back and go right instead.");
         FourthMove();
         break;
         case "2":
         WriteLine("You turn right. You go around a hallway with some twists and turns. You reach another two paths.");
         FourthMove();
         break;
         default:
         WriteLine("Invalid selection. Please try again!");
         break;
      }
   }

   private void FourthMove() 
   {
      WriteLine("\n"
      + "Now you see there are two paths ahead: left and right. Choose a path.\n"
      + "1. Left\n"
      + "2. Right");

      string? input = ReadLine();

      switch (input)
      {
         case "1":
         WriteLine("You turn left. It's very dark and you can't quite see, but you keep walking.");
         ChestDeadMove();
         break;
         case "2":
         WriteLine("You turn right. After walking down a hall you come upon a strange figure blocking your path. You get closer and...");
         FifthMove();
         break;
         default:
         WriteLine("Invalid selection. Please try again!");
         break;
      }
   }

   private void ChestDeadMove() 
   {
      WriteLine("\n"
      + "After taking some turns in the dark you find a door covered in blood. Shall you go in or should you turn back...?\n"
      + "1. Open the door...\n"
      + "2. Turn around and leave! I'm not crazy.");

      string? input = ReadLine();

      switch (input)
      {
         case "1":
         ForegroundColor = ConsoleColor.Yellow;
         WriteLine("You're a brave knight! You open the door to find another golden chest and gain 200 armor points! ");
         Points = Points + 200;
         WriteLine("You now have " + Points + " armor points!");
         ResetColor();
         WriteLine("Seeing there are no other paths you go back the way you came and take the other path. After walking down a hall you come upon a strange figure blocking your path. You get closer and...");
         FifthMove();
         break;
         case "2":
         WriteLine("You go back and take the other path...After walking down a hall you come upon a strange figure blocking your path. You get closer and...");
         FifthMove();
         break;
         default:
         WriteLine("Invalid selection. Please try again!");
         break;
      }
   }

   private void FifthMove() 
   {
      WriteLine("\n"
      + "You see the dark figure is a Wizard!\n"
      + "The wizard speaks to you: 'Hello Knight of the Round Table. You're a long way from home. You shall not pass until we play a little game. Pick a box and I will let you through. Choose wisely.' The wizard laughs eerily.\n"
      + "1. Box 1 \n"
      + "2. Box 2 \n"
      + "3. Box 3");

      string? input = ReadLine();

      switch (input)
      {
         case "1":
         ForegroundColor = ConsoleColor.Red;
         WriteLine("Ah you have opened a box containing an explosive potion. You lost all your armor points and you died immediately!");
         ResetColor();
         EndGame();
         break;
         case "2":
         ForegroundColor = ConsoleColor.Yellow;
         WriteLine("Oh my! You found the Holy Sword worth 100 armor points! Let it aid you on your quest!");
         Points = Points + 100;
         WriteLine("You now have " + Points + " armor points"); // add +100 points
         ResetColor();
         SixthMove();
         break;
         case "3":
         ForegroundColor = ConsoleColor.Red;
         WriteLine("What part of choose wisely did you not understand?! Now I must take 200 armor points. Get out of my sight.");
         Points = Points - 200;
         WriteLine("You now have " + Points + " armor points!"); // add -200 points deduction
         ResetColor();
         SixthMove();
         break;
         default:
         WriteLine("Invalid selection. Please try again!");
         break;
      }
   }

   private void SixthMove()
   {
      WriteLine("\n"
      + "You leave the wizard feeling a bit dazed. As you gather yourself, you see that you have reached three paths this time: left, right, and straight. Choose a path.\n"
      + "1. Left\n"
      + "2. Straight\n"
      + "3. Right");

      string? input = ReadLine();
      
      switch (input)
      {
         case "1":
         WriteLine("You turn left. It's a dead end. Turn back!");
         SixthMove();
         break;
         case "2":
         WriteLine("You walk straight ahead. There is a small green stairway.");
         ForegroundColor = ConsoleColor.Blue;
         WriteLine("You walk up the stairs. CONGRATULATIONS!!! You've made it to LEVEL THREE. There is something shiny glowing in the distance...");
         ResetColor();
         ForegroundColor = ConsoleColor.Yellow;
         WriteLine("...At the top of the staircase you see a bright gold treasure chest!!! You have received 500 armor points!");
         Points= Points + 500;
         WriteLine("You now have " + Points + " armor points!");
         ResetColor();
         SeventhMove();
         break;
         case "3":
         WriteLine("You turn right. There are bats at the end of the dark hallway. Turn back!");
         SixthMove();
         break;
         default:
         WriteLine("Invalid selection. Please try again!");
         break;
      }
   }

   private void SeventhMove()
   {
      WriteLine("\n"
      + "You're almost to the tower. You can hear the dragon roaring in the distance. Now you see there are two paths ahead: left and straight. Choose a path.\n"
      + "1. Left\n"
      + "2. Straight");

      string? input = ReadLine();

      switch (input)
      {
         case "1":
         WriteLine("You turn left. There is a long, dark winding hallway. You begin walking down it.");
         EighthMove(); 
         break;
         case "2":
         WriteLine("You walk straight ahead. There is a dull light glowing far in the distance...");
         ChestDead2Move(); 
         break;
         default:
         WriteLine("Invalid selection. Please try again!");
         break;
      }
   }

   private void ChestDead2Move() 
   {
      WriteLine("\n"
      + "You follow the glow and walk through some twists and turns. You reach another two paths. One path is dark and the other has the dull glow you have been following. Choose a path.\n"
      + "1. Left\n"
      + "2. Right");

      string? input = ReadLine();

      switch (input)
      {
         case "1":
         WriteLine("You turn left. You see a skeleton leaning against the dark wall. You RUN back the other way!");
         ChestDead2Move();
         break;
         case "2":
         WriteLine("You turn right and follow the glow in the distance. You feel that you must be getting close.");
         ChestDead3Move();
         break;
         default:
         WriteLine("Invalid selection. Please try again!");
         break;
      }
   }

   private void ChestDead3Move() 
   {
      WriteLine("\n"
      + "You walk down the hallway with even more twists and turns. You reach another two paths. They both have a dull light shining in the distance. Curious.\n"
      + "1. Left\n"
      + "2. Right");

      string? input = ReadLine();

      switch (input)
      {
         case "1":
         ForegroundColor = ConsoleColor.Red;
         WriteLine("You turn left. There is a bright ball of light floating at the end of the hallway. You reach for it and you fall through the floor and DIE!!!");
         ResetColor();
         WriteLine("GAME OVER!");
         Points = 0; 
         EndGame(); 
         break;
         case "2":
         ForegroundColor = ConsoleColor.Yellow;
         WriteLine("You turn right. You walk down a long hallway and find a shiny glowing chest with boots worth 400 armor points!");
         Points = Points + 400;
         WriteLine("You now have " + Points + " armor points!");
         ResetColor();
         WriteLine("There is nowhere else to go. You walk all the way back to the staircase and take the other path.");
         EighthMove();
         break;
         default:
         WriteLine("Invalid selection. Please try again!");
         break;
      }
   }

   private void  EighthMove()
   {
      WriteLine("\n"
      + "At the end of the dark hallway you see two chests. The sign above them says that you can only open one. Choose wisely!\n"
      + "1. Chest 1\n"
      + "2. Chest 2");

      string? input = ReadLine();

      switch (input)
      {
         case "1":
         ForegroundColor = ConsoleColor.Red;
         WriteLine("You open the first chest and see gold. You have been bamboozled! It was a mimic monster. It BITES you and you lose all your armor points!\n"
         + "GAME OVER!");
         ResetColor();
         Points = 0; 
         EndGame(); 
         break;
         case "2":
         ForegroundColor = ConsoleColor.Yellow;
         WriteLine("You open the second chest. You find rare armor and gain 1000 armor points.");
         Points = Points + 1000;
         WriteLine("You now have " + Points + " armor points!");
         ResetColor();
         WriteLine("You see that there is a opening in the wall behind the chests. You crawl through the opening...");
         NinthMove(); 
         break;
         default:
         WriteLine("Invalid selection. Please try again!");
         break;
      }
   }

   private void  NinthMove() 
   {
      WriteLine("\n"
      + "...You crawl through the opening in the wall and see large golden doors. You hear low growling behind the door. You must be at the entrance of the tower. You gather all the strength you can muster and open the doors and see a large black dragon with red eyes that pierce your soul! He lunges at you and you smack him away with your sword. You see the princess chained up at the end of the room. You MUST save her. The dragon flies into the air and rushes towards you...\n"
      + "");
      ForegroundColor = ConsoleColor.Yellow;
      WriteLine("You have " + Points + " armor points. Do you have enough to defeat the dragon?!");
      ResetColor();
      WriteLine("Press any key...");
      ReadKey();

      if (Points >= 2450) 
      {
         ForegroundColor = ConsoleColor.Cyan;
         WriteLine("\n"
         + "You block his teeth with your shield and stab him underneath as he flies over you. You have SLAYED THE DRAGON! You release the princess from her chains. The princess is so moved by your victory!\n"
         + "You and the princess are wed and you become KING in Happily Ever After!");
         ResetColor();
         WriteLine("THE END!");
         EndGame(); 
      }

      else if (Points >= 2000)
      //&& Points < 2250
      {
         ForegroundColor = ConsoleColor.Yellow;
         WriteLine("\n"
         + "You block his teeth with your shield and your sword is knocked away. The dragon has you cornered! As he bares his teeth to attack you hear a slashing sound and he drops to the ground. The princess has your sword and has slayed the dragon! The sword must have fallen within her reach and she escaped the chains and saved you!\n"
         + "The princess is grateful for you help. She throws you a party and you gain a noble title.");
         ResetColor();
         WriteLine("THE END!");
         EndGame(); 
      }

      else {
         ForegroundColor = ConsoleColor.Red;
         WriteLine("\n"
         + "You try to block his teeth with your shield, but it breaks immediately. You are crushed by the dragon and DIE.\n" 
         + "You have FAILED to save the princess and died with DISHONOR!");
         ResetColor();
         EndGame(); 
      }
   }

}
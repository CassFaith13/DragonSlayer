using static System.Console;

public class ProgramUI 
{
    public void Run() {
            RunApplication();
    }

    private void RunApplication()
    {
      bool isRunning = true;
      while(isRunning)
      {
         System.Console.WriteLine("welcome To Dragon Slayer\n"+
                              "1. Start Game\n"+
                              "2. End Game\n");

                        string userInput=Console.ReadLine();

                        switch (userInput)
                        {

                            case "1":
                            StartGame();
                            break;

                             case "2":
                             isRunning=EndGame();
                            break;

                            default:
                            System.Console.WriteLine("invalid, selection please try again");
                            break;
                        }
      }
    }

    private void StartGame()
    {
        Clear();
        WriteLine("welcome to your jounry");
        ReadKey();
    }  
       private bool EndGame()
    {

       PressanyKey(); 
       return false;
    }

    private void PressanyKey()
    {
       System.Console.WriteLine("Press any key to continue");
       ReadKey();
    }
}

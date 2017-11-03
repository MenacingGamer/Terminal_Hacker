
using UnityEngine;

public class Hacker : MonoBehaviour
{
    const string menuHint = "Type menu to go back to main menu.";
    string[] level1Passwords = {"books", "author", "hardcover", "index", "newspaper", "magazine"};
    string[] level2Passwords = { "license", "automobiles", "registration", "tickets", "motorcycles", "transportation" };
    string[] level3Passwords = { "precinct", "lockup", "detective", "lieutenant", "uniform", "commissioner" };
    string[] level4Passwords = { "counterterrorism", "investigating", "counterintelligence" };
    int level;

    enum Screen { MainMenu, Password, Win}
    Screen currentScreen;
    string password;

    // Use this for initialization
    void Start()
    {
        
        ShowMainMenu();

    }

    void ShowMainMenu()
    {
        currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        Terminal.WriteLine("What Would You Like To Hack?");
        Terminal.WriteLine("Press 1 for the local library (EASY)");
        Terminal.WriteLine("Press 2 for the local DMV (MEDIUM)");
        Terminal.WriteLine("Press 3 for the police station (HARD)");
        Terminal.WriteLine("Press 4 for the CIA (IMPOSSIBLE)");
        Terminal.WriteLine("Enter your selecion:");
     
    }

    

    void OnUserInput(string input)
    {
        if (input == "menu")
        {
            ShowMainMenu();
        }
        else if (input == "quit" || input == "exit" || input == "close")
        {
            Terminal.WriteLine("If on web close tab.");
            Application.Quit();
        }
        else if (input == "fuck" || input == "shit" || input == "dick head" || input == "pussy" || input == "fuck head" || input == "fuck face" || input == "ass" || input == "ass face" || input == "shit face" || input == "shit head")
        {
            Terminal.WriteLine("You have a dirty mouth");
        }
        else if (input == "pause" || input == "stop" || input == "wait" || input == "hold on" || input == "still trying")
        {
            Terminal.WriteLine("Whats wrong you need a break?");
        }
        else if (input == "007")
        {
            Terminal.WriteLine("Mr Bond Dont blow your cover.");
        }
        else if (input == "69")
        {
            Terminal.WriteLine("you have a dirty mind!");
        }
        else if (input == "187")
        {
            Terminal.WriteLine("Get Em killer");
        }
        else if (input == "420")
        {
            Terminal.WriteLine("YOU POT HEAD!");
        }
        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
        else if (currentScreen == Screen.Password)
        {
            CheckPassword(input);
        }
    }

    void RunMainMenu(string input)
    {
        bool isValidLevelNumber = (input == "1" || input == "2" || input == "3" || input == "4");
        if (isValidLevelNumber)
        {
            level = int.Parse(input);
            AskForPassword();
        }
     
        else if (input == "007")
        {
            Terminal.WriteLine("Mr Bond Dont blow your cover.");
        }
        else if (input == "fuck" || input == "shit" || input == "dick head" || input == "pussy" || input == "fuck head" || input == "fuck face" || input == "ass" || input == "ass face" || input == "shit face" || input == "shit head")
        {
            Terminal.WriteLine("You have a dirty mouth");
        }
        else if (input == "69")
        {
            Terminal.WriteLine("you have a dirty mind!");
        }
        else if (input == "187")
        {
            Terminal.WriteLine("Get Em killer");
        }
        else if (input == "420")
        {
            Terminal.WriteLine("YOU POT HEAD!");
        }
        else
        {
            Terminal.WriteLine("Please Pick a valid level");
            Terminal.WriteLine(menuHint);
        }
    }

    void AskForPassword()
    {
        currentScreen = Screen.Password;
        Terminal.ClearScreen();
        SetRandomPassword();
        Terminal.WriteLine(menuHint);
        Terminal.WriteLine("Guess the password, hint: " + password.Anagram());
       
    }

    void SetRandomPassword()
    {
        switch (level)
        {
            case 1:
                password = level1Passwords[Random.Range(0, level1Passwords.Length)];
                break;
            case 2:
                password = level2Passwords[Random.Range(0, level2Passwords.Length)];
                break;
            case 3:
                password = level3Passwords[Random.Range(0, level3Passwords.Length)];
                break;
            case 4:
                password = level4Passwords[Random.Range(0, level4Passwords.Length)];
                break;
            default:
                Debug.Log("Invalid level number");
                break;
        }
    }

    void CheckPassword(string input)
    {
        if (input == password)
        {
            DisplayWinScreen();
        }
        else
        {
            AskForPassword();
        }
    }

    void DisplayWinScreen()
    {
        currentScreen = Screen.Win;
        Terminal.ClearScreen();
        ShowLevelReward();
        Terminal.WriteLine(menuHint);
    }

    void ShowLevelReward()
    {
        switch (level)
        {
            case 1:
                 Terminal.WriteLine("WELL DONE YOU FOUND THE HIDDEN FILES!");
                Terminal.WriteLine(@"
           ______________________
          (~~~~~  local ~~~~~~~ (  )
         / ~~~ news paper  ~~~  / /
        /local dmv hacked!!    / /
       / password:registration/ /
      /    ~~~~~~~~~~~~~~    / /
     /  ~~~~~~~~~~~~~~~~~   / /
    ( _____________________(  ) 
 "                                              
);
                break;
            case 2:
                Terminal.WriteLine("WELL DONE YOU FOUND THE WARDENS LICENSE PLATE!");
                Terminal.WriteLine(@"
    ________________________________
    |  |___|                |____|  ||
    |       ___   ___           ___ ||
    |  |   |   | |    | / |  | |___|||
    |  |   |   | |    |/  |  | |    ||
    |  |__ |___| |___ | \ |__| |    ||
    |_______________________________||
 "
);
                break;
            case 3:
                Terminal.WriteLine("WELL DONE YOU FOUND THE CIA INFORMANTS BADGE!");
                Terminal.WriteLine(@"
    ________________________________
    |  ~~~~~~     ~~~~~ ~~~~~~      |
    |  ~~~~~~            (.)   (.)  |
    | ~~~~~~~               //      |
    |  CIA: TOP SECRET    \____/    |
    | CLEARANCE: investigating      |
    |_______________________________|
 "
);
                break;
            case 4:
                Terminal.WriteLine("WELL DONE YOU FOUND TOP SECRET FILES!");
                Terminal.WriteLine(@"
     __________  ____  _____   
    (TOP SECRET()    ()     ()  
    |~~~~~~~~~ ||~~~ ||~~~~~||  
    |~~~~~~~~~ ||~~~ ||~~~~~||  
    |~~~~~~~~~ ||~~~ ||~~~~~||  
    (__________()____()_____()  
 "
);
                break;
            default:
                Debug.Log("Invalid level number");
                break;
        }
    }
}

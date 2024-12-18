using System;
namespace TheShadowKnight
{
    public class MainMenu
    {
        static String ans;
        static String ans1;
        static bool error;
        public static void Main(String[] args)
        {
            while (true)
            {
                error = true;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("                        _____\r\n                        \\   /\r\n                        |   |\r\n           .__.         |   |_____________________________________________\r\n           |  |_________|   |                                              \\\r\n           |  |         |   |________________________________________________\\\r\n _____ _            _____ _               _                 _   __      _       _     _\r\n|_   _| |          /  ___| |             | |               | | / /     (_)     | |   | |\r\n  | | | |__   ___  \\ `--.| |__   __ _  __| | _____      __ | |/ / _ __  _  __ _| |__ | |_\r\n  | | | '_ \\ / _ \\  `--. | '_ \\ / _` |/ _` |/ _ \\ \\ /\\ / / |    \\| '_ \\| |/ _` | '_ \\| __|\r\n  | | | | | |  __/ /\\__/ | | | | (_| | (_| | (_) \\ V  V /  | |\\  | | | | | (_| | | | | |_\r\n  \\_/ |_| |_|\\___| \\____/|_| |_|\\__,_|\\__,_|\\___/ \\_/\\_/   \\_| \\_|_| |_|_|\\__, |_| |_|\\__|\r\n                             _____________________________________________ __/ |\r\n           |  |_________|   |                                             |___/\r\n           |__|         |   |_____________________________________________ /\r\n                        |   |\r\n                        |   |\r\n                        /___\\\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("[1] NEW GAME");
                Console.WriteLine("[2] LOAD GAME");
                Console.WriteLine("[3] CAMPAIGN MODE");
                Console.WriteLine("[4] CREDITS");
                Console.WriteLine("[5] EXIT");
                Console.Write("Enter option: ");
                ans = Console.ReadLine();

                if (ans.Equals("1"))
                {
                    Console.Clear();
                    CharacterCreation.Character();
                    while (error == true)
                    {
                        Console.WriteLine("\nReturn to Main Menu? [Y/N]");
                        ans = Console.ReadLine();
                        if (ans.ToUpper().Equals("Y"))
                        {
                            error = false;
                            Console.Clear();
                            continue;
                        }
                        else if (ans.ToUpper().Equals("N"))
                        {
                            Console.WriteLine("Thank you for playing the game!");
                            Console.WriteLine("Exiting in 5 seconds...");
                            Thread.Sleep(5000);
                            System.Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("Invalid option! Please try again.");
                            continue;
                        }
                    }
                }
                else if (ans.Equals("2"))
                {
                    Console.Clear();
                    LoadGame.LoadCharacter();
                }
                else if (ans.Equals("3"))
                {
                    Console.Clear();
                    CampaignMode.Campaign();
                    while (error == true)
                    {
                        Console.WriteLine("\nReturn to Main Menu? [Y/N]");
                        ans = Console.ReadLine();
                        if (ans.ToUpper().Equals("Y"))
                        {
                            error = false;
                            Console.Clear();
                            continue;
                        }
                        else if (ans.ToUpper().Equals("N"))
                        {
                            Console.WriteLine("Thank you for playing the game!");
                            Console.WriteLine("Exiting in 5 seconds...");
                            Thread.Sleep(5000);
                            System.Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("Invalid option! Please try again.");
                            continue;
                        }
                    }
                }
                else if (ans.Equals("4"))
                {
                    Console.Clear();
                    Credits.Cred();
                    while (error == true)
                    {
                        Console.WriteLine("\nReturn to Main Menu? [Y/N]");
                        ans = Console.ReadLine();
                        if (ans.ToUpper().Equals("Y"))
                        {
                            error = false;
                            Console.Clear();
                            continue;
                        }
                        else if (ans.ToUpper().Equals("N"))
                        {
                            Console.WriteLine("Thank you for playing the game!");
                            Console.WriteLine("Exiting in 5 seconds...");
                            Thread.Sleep(5000);
                            System.Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("Invalid option! Please try again.");
                            continue;
                        }
                    }
                }
                else if (ans.Equals("5"))
                {
                    Console.WriteLine("Thank you for playing the game!");
                    Console.WriteLine("Exiting in 5 seconds...");
                    Thread.Sleep(5000);
                    System.Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid option! Please try again.");
                    Console.WriteLine("\nPress any key to continue");
                    ans1 = Console.ReadLine();
                    Console.Clear();
                    continue;
                }
            }
        }
    }
}

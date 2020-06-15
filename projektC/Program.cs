using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectC
{
    class Program
    {
        //========================STARTING GAME========================
        public static void StartGame()
        {
            Game RoundGame = new Game();
            RoundGame.CreateArray();
            RoundGame.PrintArray();
            RoundGame.CheckKey();
            RoundGame.PrintArray();
            Console.ReadKey();
        }
        //========================STARTING GAME========================

        public static void Nav()
        {
            Console.Clear();
            Console.WriteLine("                                               WELCOME IN MY GAME!");
            Console.WriteLine("                                         ___________________________________");
            Console.WriteLine("[1] - START");
            Console.WriteLine("[2] - GAME RULES");
            Console.WriteLine("[0] - QUIT");
        }

        public static void Rules(bool flaga = true)
        {
            Console.WriteLine("                                               WELCOME IN MY GAME!");
            Console.WriteLine("                                         ___________________________________");
            Console.WriteLine("Rules:");
            Console.WriteLine("1. Arrange numbers from 0 - 8 by press the arrow keys");
            Console.WriteLine("2. You win when your board looks like \n \n | 0 | | 1 | | 2 |\n | 3 | | 4 | | 5 | \n | 6 | | 7 | | 8 | \n ");
            Console.WriteLine("Press [0] key to back");

            while (flaga)
            {
                ConsoleKeyInfo rulesKey = Console.ReadKey();
                if (rulesKey.Key == ConsoleKey.D0)
                {
                    flaga = false;
                    break;
                }
                else
                {
                    flaga = true;
                    Console.WriteLine("Please use correct key");
                }
            }
        }

        public static void StartMenu()
        {
            Console.Title = "Damian Cygan Project";
            bool flaga = true;
            bool gameflaga = true;
            while (gameflaga)
            {
                Nav();
                ConsoleKeyInfo menuKey = Console.ReadKey();
                switch (menuKey.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        StartGame();
                        //gameflaga = false;
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        Rules(flaga);
                        break;
                    case ConsoleKey.D0:
                    case ConsoleKey.Escape:
                        Console.Clear();
                        Console.WriteLine("Bye!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.Write("Wrong key. Please choose [1], [2] or [0] key");
                        Console.ReadKey();
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            StartMenu();
            StartGame();
        }
    }
}

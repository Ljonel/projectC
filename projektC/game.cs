﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectC
{
    class Game
    {
        public int[,] arr = new int[3, 3]; //plansza 3x3
        public int temp;
  
        public void CreateArray()
        {
            arr[0, 0] = 1;
            arr[0, 1] = 4;
            arr[0, 2] = 2;
            arr[1, 0] = 3;
            arr[1, 1] = 5;
            arr[1, 2] = 8;
            arr[2, 0] = 6;
            arr[2, 1] = 7;
            arr[2, 2] = 0;
        }

        public void Check()             
        {
            if (arr[0, 0] == 0 &&
            arr[0, 1] == 1 &&
            arr[0, 2] == 2 &&
            arr[1, 0] == 3 &&
            arr[1, 1] == 4 &&
            arr[1, 2] == 5 &&
            arr[2, 0] == 6 &&
            arr[2, 1] == 7 &&
            arr[2, 2] == 8)
            {
                Console.Clear();
                Console.WriteLine("You win!");
                Console.WriteLine("Press [0] or Escape to exit");
                
                ConsoleKeyInfo endKey;
                endKey = Console.ReadKey();
                switch (endKey.Key)
                {
                    case ConsoleKey.D0: //[0] QUIT
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                }
            }
        }

        public void PrintArray()
        {
            Console.Clear();
            Console.WriteLine("==================================================\n");
            Console.ForegroundColor = ConsoleColor.Red;

            for (int i = 0; i < 3; i++) //row
            {
                for (int j = 0; j < 3; j++) //column
                {
                    if (arr[i, j] == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"  |   {arr[i, j]}  |");

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($"  |   {arr[i, j]}  |");
                    }
                }
                Console.WriteLine("\n");
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("==================================================");
            Console.WriteLine("[0] - QUIT");
        }

        public void CheckKey()
        {
            try
            {
                for (int i = 0; i < 3; i++) //row
                {
                    for (int j = 0; j < 3; j++) //column
                    {
                        while (arr[i, j] == 0)
                        {
                            ConsoleKeyInfo move;   
                            move = Console.ReadKey(); 

                            switch (move.Key)  
                            {
                                case ConsoleKey.LeftArrow: 

                                    Console.Clear();
                                    temp = arr[i, j];
                                    arr[i, j] = arr[i, j - 1]; //left one column
                                    arr[i, j - 1] = temp;
                                    j = j - 1;
                                    break;

                                case ConsoleKey.UpArrow:  
                                    Console.Clear();
                                    temp = arr[i, j];
                                    arr[i, j] = arr[i - 1, j]; //higher one row
                                    arr[i - 1, j] = temp;
                                    i = i - 1;
                                    break;

                                case ConsoleKey.DownArrow: 
                                    Console.Clear();
                                    temp = arr[i, j];
                                    arr[i, j] = arr[i + 1, j]; //lower one row
                                    arr[i + 1, j] = temp;
                                    i = i + 1;
                                    break;

                                case ConsoleKey.RightArrow: 
                                    Console.Clear();
                                    temp = arr[i, j];
                                    arr[i, j] = arr[i, j + 1]; //right one column
                                    arr[i, j + 1] = temp;
                                    j = j + 1;
                                    break;
                                case ConsoleKey.D0: //[0] QUIT
                                    Console.WriteLine("Do you want surrender? \n y/n?");
                                    string surrender = Console.ReadLine();
                                    string srr = surrender.ToLower();
                                    if (srr == "y")
                                    {
                                        Console.Clear();
                                        Console.Write(":(");
                                        Console.ReadKey();
                                        Environment.Exit(0);
                                    }
                                    else if (srr == "n")
                                    {
                                        continue;
                                    }
                                    break;
                            }
                            PrintArray();
                            Check();        // 0,1,2 !!
                                            // 3,4,5
                                            // 6,7,8
                            CheckKey();
                            
                        }
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("You can't press key like that");
            }

        }

    }
}

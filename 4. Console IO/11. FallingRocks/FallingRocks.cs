using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace JustFallingRocks
{
    struct Rock
    {
        int x;
        int y;
        char c;
        byte size;
        ConsoleColor color;

        public Rock(int X, int Y, char C, byte Size, ConsoleColor Color)
        {
            this.x = X;
            this.y = Y;
            this.c = C;
            this.size = Size;
            this.color = Color;
        }

        public int X
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }

        public int Y
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
            }
        }

        public char C
        {
            get
            {
                return this.c;
            }
            set
            {
                this.c = value;
            }
        }

        public byte Size
        {
            get
            {
                return this.size;
            }
            set
            {
                this.size = value;
            }
        }

        public ConsoleColor Color
        {
            get
            {
                return this.color;
            }
            set
            {
                this.color = value;
            }
        }
    }

    class FallingRocks
    {
        static int dwarfX = Console.WindowWidth / 2 - 2;
        static int dwarfY = Console.WindowHeight - 1;
        static string dwarf = "(0)";
        static int maxRocksOnOneRow = 5;
        static string allowedChars = "^@*&+%$#!.;-";
        static ConsoleColor[] allowedColors = 
        {
            ConsoleColor.DarkCyan,
            ConsoleColor.Magenta,
            ConsoleColor.Blue,
            ConsoleColor.Green,
            ConsoleColor.Cyan,
            ConsoleColor.DarkMagenta,
            ConsoleColor.Green,
            ConsoleColor.Gray,
            ConsoleColor.Red,
            ConsoleColor.Cyan,
            ConsoleColor.Blue,
            ConsoleColor.Magenta
        };
        static int maxRockSize = 3;
        static int result = 0;
        static List<Rock> allRocks = new List<Rock>();

        static void FixTheScreen()
        {
            Console.BufferWidth = Console.WindowWidth;
            Console.BufferHeight = Console.WindowHeight;
        }

        static void DrawDwarf()
        {
            Console.SetCursorPosition(dwarfX, dwarfY);
            Console.Write(dwarf);
        }

        static void MoveDwarfLeft()
        {
            if (dwarfX != 0)
            {
                dwarfX--;
            }
        }

        static void MoveDwarfRight()
        {
            if (dwarfX < Console.WindowWidth - dwarf.Length)
            {
                dwarfX++;
            }
        }

        static void GenerateRowOfRocks()
        {
            Random randomNumber = new Random();
            int numberOfRocks = randomNumber.Next(1, maxRocksOnOneRow);
            for (int i = 0; i < numberOfRocks; i++)
            {
                int randomX = randomNumber.Next(1, Console.WindowWidth);
                int randomChar = randomNumber.Next(0, allowedChars.Length);
                byte randomRockSize = (byte)randomNumber.Next(1, maxRockSize + 1);
                Rock rock = new Rock(randomX, 0, allowedChars[randomChar], randomRockSize, allowedColors[randomChar]);
                allRocks.Add(rock);
            }
        }

        static void DrawRocks()
        {
            GenerateRowOfRocks();

            for (int i = 0; i < allRocks.Count; i++ )
            {
                Rock tempRock = allRocks[i];
                tempRock.Y++;
                allRocks[i] = tempRock;
                if (allRocks[i].Y == Console.WindowHeight)
                {
                    result += allRocks[i].Size;
                    allRocks.RemoveAt(i);
                }
                else if (dwarfX + 2 >= allRocks[i].X && dwarfX < allRocks[i].X + allRocks[i].Size && allRocks[i].Y == dwarfY)
                {
                    GameOver();
                }
                else
                {
                    Console.SetCursorPosition(allRocks[i].X, allRocks[i].Y);
                    for (int j = 0; j < allRocks[i].Size; j++)
                    {
                        Console.ForegroundColor = allRocks[i].Color;
                        Console.Write(allRocks[i].C);
                        Console.ResetColor();
                    }
                }
            }
        }

        static void GameOver()
        {
            Console.Clear();
            Console.SetCursorPosition(Console.WindowWidth / 2 - 20, Console.WindowHeight / 2);
            Console.WriteLine("Game Over! You've ended with {0} points!", result);
            allRocks.Clear();
            result = 0;
            Console.ReadKey();
        }

        static void Main()
        {
            FixTheScreen();
            //List<Rock> allRocks = new List<Rock>();
            GenerateRowOfRocks();
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo move = Console.ReadKey();
                    if (move.Key == ConsoleKey.LeftArrow)
                    {
                        MoveDwarfLeft();
                    }
                    else
                    {
                        MoveDwarfRight();
                    }
                }

                Console.Clear();
                DrawDwarf();
                DrawRocks();

                Thread.Sleep(150);
            }
        }
    }
}
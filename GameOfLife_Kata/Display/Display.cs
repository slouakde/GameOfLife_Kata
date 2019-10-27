using System;
using System.Collections.Generic;

namespace GameOfLife_Kata.Display
{
    public static class Display
    {
        public static void DisplayWelcome(List<Tuple<int, int>> GameOfLife)
        {
            Console.SetWindowSize(AppConstants.x_grid, AppConstants.y_grid+4);
            Console.WriteLine("Welcome to the game of life");
            Console.WriteLine("Press ENTER to start");
            Console.WriteLine("Press ESC to stop");

            DisplayGameOfLifeGrid(GameOfLife);

            Console.ReadLine();
            Console.Clear();
            Console.SetWindowSize(60, 31);
        }

        public static void DisplayResult(string FizzBuzz, List<Tuple<int, int>> GameOfLife)
        {
            Console.WriteLine(FizzBuzz);
            DisplayGameOfLifeGrid(GameOfLife);
            Console.SetCursorPosition(0, 0);
        }

        public static void DisplayGameOfLifeGrid(List<Tuple<int, int>> GameOfLife)
        {
            for (int y = 0; y < AppConstants.y_grid; y++)
            {
                for (int x = 0; x < AppConstants.x_grid; x++)
                {
                    if (GameOfLife.Contains(new Tuple<int, int>(x, y)))
                        Console.Write("X");
                    else
                        Console.Write("-");
                }
                Console.WriteLine();
            };
        }

        public static void ClearScreen()
        {
            Console.WriteLine("        ");
            Console.SetCursorPosition(0, 0);
        }
    }
}

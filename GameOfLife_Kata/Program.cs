using System;
using System.Collections.Generic;

namespace GameOfLife_Kata
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tuple<int, int>> start = new List<Tuple<int, int>>();
            start.AddRightGliderOne();
            Display.Display.DisplayWelcome(start);            
            var currentState = start;

            do
            {
                int i = 0;
                int j = 0;
                while (!Console.KeyAvailable)
                {
                    Display.Display.ClearScreen();

                    var FizzBuzzResult = FizzBuzz.FizzBuzzEngine.GetFizzBuzzResult(i);                    
                    currentState = GameOfLife.StateEngine.GetNewState(currentState);
                    Display.Display.DisplayResult(FizzBuzzResult, currentState);
                                       
                    j++;
                    if (j % 10 == 0)
                    {
                        i++;
                    }
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}

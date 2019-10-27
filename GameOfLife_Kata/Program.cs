using System;
using System.Collections.Generic;

namespace GameOfLife_Kata
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tuple<int, int>> start = new List<Tuple<int, int>>();
            Display.Display.DisplayWelcome(start);            
            var currentState = start;

            do
            {
                int i = 0;
                int j = 0;
                while (!Console.KeyAvailable)
                {
                    Display.Display.ClearScreen();

                    var fizzBuzzResult = FizzBuzz.FizzBuzzEngine.GetFizzBuzzResult(i);                    
                    currentState = GameOfLife.StateEngine.GetNewState(currentState);

                    if (j % 10 == 0)
                    {
                        currentState = GameOfLife.StateEngine.AddFizzBuzzGliders(currentState, fizzBuzzResult);
                    }

                    Display.Display.DisplayResult(fizzBuzzResult, currentState);
                                       
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

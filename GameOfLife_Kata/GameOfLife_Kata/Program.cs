using System;
using System.Collections.Generic;

namespace GameOfLife_Kata
{
    class Program
    {
        const int fizz = 3;
        const int buzz = 5;
        const int fizzbuzz = 15;


        static void Main(string[] args)
        {
            Console.SetWindowSize(60, 34);

            Console.WriteLine("Welcome to the game of life");
            Console.WriteLine("Press ENTER to start");
            Console.WriteLine("Press ESC to stop");

            int x_grid = 30;
            int y_grid = 60;

            List<Tuple<int, int>> start = new List<Tuple<int, int>>();

            for (int x = 0; x < x_grid; x++)
            {
                //Swap this round to fix but leave out of the puzzle -- intentional bug
                for (int y = 0; y < y_grid; y++)
                {
                    if (start.Contains(new Tuple<int, int>(x, y)))
                        Console.Write("X");
                    else
                        Console.Write("-");
                }
                Console.WriteLine();
            };

            var current_state = start;
            Console.ReadLine();
            Console.Clear();
            Console.SetWindowSize(60, 31);

            do
            {
                int i = 0;
                int j = 0;
                while (!Console.KeyAvailable)
                {
                    Console.WriteLine("        ");
                    Console.SetCursorPosition(0, 0);

                    if (i % fizz == 0)
                    {
                        if (i % buzz == 0)
                        {
                            Console.WriteLine("FizzBuzz");
                        }
                        else //delete this for a bug ever fizzbuzz
                            Console.WriteLine("Fizz");
                    }
                    else
                    {
                        if (i % buzz == 0)
                        {
                            Console.WriteLine("Buzz");
                        }
                        else
                            Console.WriteLine(i);
                    }

                    var old_state = current_state;
                    current_state = new List<Tuple<int, int>>();

                    if (j % 10 == 0)
                    {
                        if (i % fizzbuzz == 0)
                        {
                            AddRightGliderOne(current_state);
                        }
                        else if (i % buzz == 0)
                        {
                            AddLeftGliderTwo(current_state);
                        }
                        else if (i % fizz == 0)
                        {
                            AddLeftGliderOne(current_state);
                        }

                    }

                    for (int x = 0; x < x_grid; x++)
                    {
                        //Swap this round to fix but leave out of the puzzle -- intentional bug
                        for (int y = 0; y < y_grid; y++)
                        {
                            var neighbours = new List<Tuple<int, int>>();
                            neighbours.AddPoint(x + 1, y);
                            neighbours.AddPoint(x + 1, y + 1);
                            neighbours.AddPoint(x + 1, y - 1);
                            neighbours.AddPoint(x, y + 1);
                            neighbours.AddPoint(x, y - 1);
                            neighbours.AddPoint(x - 1, y);
                            neighbours.AddPoint(x - 1, y + 1);
                            neighbours.AddPoint(x - 1, y - 1);

                            var pixel_previously_alive = old_state.Contains(new Tuple<int, int>(x, y));
                            var live_neighbours = new List<Tuple<int, int>>();
                            foreach (var neighbour in neighbours)
                            {
                                if (old_state.Contains(neighbour))
                                {
                                    live_neighbours.Add(neighbour);
                                }
                            }

                            if (pixel_previously_alive)
                            {
                                if (live_neighbours.Count == 2 || live_neighbours.Count == 3)
                                {
                                    current_state.Add(new Tuple<int, int>(x, y));
                                }

                            }
                            else
                            {
                                if (live_neighbours.Count == 3)
                                {
                                    current_state.Add(new Tuple<int, int>(x, y));
                                }
                            }

                            if (current_state.Contains(new Tuple<int, int>(x, y)))
                                Console.Write("X");
                            else
                                Console.Write("-");
                        }
                        Console.WriteLine();
                    };

                    Console.SetCursorPosition(0, 0);

                    j++;
                    if (j % 10 == 0)
                    {
                        i++;
                    }
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }



        private static void AddLeftGliderOne(List<Tuple<int, int>> state)
        {
            state.AddPoint(1, 12);
            state.AddPoint(2, 13);
            state.AddPoint(3, 11);
            state.AddPoint(3, 12);
            state.AddPoint(3, 13);
        }

        private static void AddLeftGliderTwo(List<Tuple<int, int>> state)
        {
            state.AddPoint(11, 2);
            state.AddPoint(12, 3);
            state.AddPoint(13, 1);
            state.AddPoint(13, 2);
            state.AddPoint(13, 3);
        }

        private static void AddRightGliderOne(List<Tuple<int, int>> state)
        {
            state.AddPoint(1, 38);
            state.AddPoint(2, 37);
            state.AddPoint(3, 37);
            state.AddPoint(3, 38);
            state.AddPoint(3, 39);
        }
    }
}

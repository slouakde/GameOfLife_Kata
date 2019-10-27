using System;
using System.Collections.Generic;

namespace GameOfLife_Kata
{
    class Program
    {
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

                    if (i % 3 == 0)
                    {
                        if (i % 5 == 0)
                        {
                            Console.WriteLine("FizzBuzz");
                        }
                        else
                            Console.WriteLine("Fizz");
                    }
                    else
                    {
                        if (i % 5 == 0)
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
                        if (i % 15 == 0)
                        {
                            AddRightGliderOne(current_state);
                        }
                        else if (i % 3 == 0)
                        {
                            AddLeftGliderOne(current_state);
                        }
                        else if (i % 5 == 0)
                        {
                            AddLeftGliderTwo(current_state);
                        }

                    }

                    for (int x = 0; x < x_grid; x++)
                    {
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
            AddLeftGlider(state, 2, 12);
        }

        private static void AddLeftGliderTwo(List<Tuple<int, int>> state)
        {
            AddLeftGlider(state, 11, 2);
        }

        private static void AddRightGliderOne(List<Tuple<int, int>> state)
        {

            AddRightGlider(state, 4, 36);
        }

        private static void AddLeftGlider(List<Tuple<int, int>> state, int x, int y)
        {
            state.AddPoint(x - 1, y);
            state.AddPoint(x, y + 1);
            state.AddPoint(x + 1, y - 1);
            state.AddPoint(x + 1, y);
            state.AddPoint(x + 1, y + 1);
        }

        private static void AddRightGlider(List<Tuple<int, int>> state, int x, int y)
        {
            state.AddPoint(x - 1, y);
            state.AddPoint(x, y - 1);
            state.AddPoint(x + 1, y - 1);
            state.AddPoint(x + 1, y);
            state.AddPoint(x + 1, y + 1);
        }
    }
}

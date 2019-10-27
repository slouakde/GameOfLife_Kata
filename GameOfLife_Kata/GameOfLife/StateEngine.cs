using System;
using System.Collections.Generic;

namespace GameOfLife_Kata.GameOfLife
{
    public static class StateEngine
    {
        public static List<Tuple<int, int>> GetNewState(List<Tuple<int, int>> CurrentState)
        {
            var oldState = CurrentState;
            var newState = new List<Tuple<int, int>>();

            for (int y = 0; y < AppConstants.y_grid; y++)
            {
                for (int x = 0; x < AppConstants.x_grid; x++)
                {
                    var neighbours = GetNeighbours(x, y);
                    var liveNeighbours = GetLiveNeighbours(neighbours, oldState);

                    var currentPixelState = CurrentCellState(oldState, new Tuple<int, int>(x, y));

                    switch (currentPixelState)
                    {
                        case "Alive":
                            if (liveNeighbours.Count == 2 || liveNeighbours.Count == 3)
                            {
                                newState.AddPoint(x, y);
                            }
                            break;
                        case "Dead":
                            if (liveNeighbours.Count == 3)
                            {
                                newState.AddPoint(x, y);
                            }
                            break;
                    }
                }
            };

            return newState;
        }

        public static List<Tuple<int, int>> AddFizzBuzzGliders(List<Tuple<int, int>> CurrentState, string FizzBuzzResult)
        {
            switch (FizzBuzzResult)
            {
                case "Fizz":
                    CurrentState.AddLeftGliderOne();
                    break;
                case "Buzz":
                    CurrentState.AddLeftGliderTwo();
                    break;
                case "FizzBuzz":
                    CurrentState.AddRightGliderOne();
                    break;
            }
            return CurrentState;
        }

        private static List<Tuple<int, int>> GetNeighbours(int x, int y)
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

            return neighbours;
        }

        private static List<Tuple<int, int>> GetLiveNeighbours(List<Tuple<int, int>> neighbours, List<Tuple<int, int>> oldState)
        {
            var liveNeighbours = new List<Tuple<int, int>>();

            foreach (var neighbour in neighbours)
            {
                if (oldState.Contains(neighbour))
                {
                    liveNeighbours.Add(neighbour);
                }
            }

            return liveNeighbours;
        }

        private static string CurrentCellState(List<Tuple<int, int>> oldState, Tuple<int, int> currentCell)
        {
            return oldState.Contains(currentCell) ? "Alive" : "Dead";
        }
    }
}

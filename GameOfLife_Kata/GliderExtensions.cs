using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife_Kata
{
    public static class Glider
    {
        public static void AddLeftGliderOne(this List<Tuple<int, int>> state)
        {
            state.AddLeftGlider(12, 2);
        }

        public static void AddLeftGliderTwo(this List<Tuple<int, int>> state)
        {
            state.AddLeftGlider(2, 11);
        }

        public static void AddRightGliderOne(this List<Tuple<int, int>> state)
        {
            state.AddRightGlider(36, 4);
        }

        private static void AddLeftGlider(this List<Tuple<int, int>> state, int x, int y)
        {
            state.AddPoint(x - 1, y);
            state.AddPoint(x, y + 1);
            state.AddPoint(x + 1, y - 1);
            state.AddPoint(x + 1, y);
            state.AddPoint(x + 1, y + 1);
        }

        private static void AddRightGlider(this List<Tuple<int, int>> state, int x, int y)
        {
            state.AddPoint(x + 1, y);
            state.AddPoint(x, y + 1);
            state.AddPoint(x - 1, y - 1);
            state.AddPoint(x - 1, y);
            state.AddPoint(x - 1, y + 1);
        }
    }
}

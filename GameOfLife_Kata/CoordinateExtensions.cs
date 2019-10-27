using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife_Kata
{
    public static class CoordinateExtensions
    {
        public static void AddPoint(this List<Tuple<int, int>> state, int x, int y)
        {
            state.Add(new Tuple<int, int>(x, y));
        }
    }
}

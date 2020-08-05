using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class SubrectangleQueries : ISubrectangleQueries
    {
        private int[][] _rectangle;
        public SubrectangleQueries(int[][] rectangle)
        {
            _rectangle = rectangle;
        }

        public void UpdateSubrectangle(int row1, int col1, int row2, int col2, int newValue)
        {
            for (int r = row1; r <= row2; r++)
                for (int c = col1; c <= col2; c++)
                    _rectangle[r][c] = newValue;
            var a = _rectangle;
        }

        public int GetValue(int row, int col)
        {
            return _rectangle[row][col];
        }
    }
}

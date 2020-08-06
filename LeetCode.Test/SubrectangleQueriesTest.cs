using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Test
{
    public class SubrectangleQueriesTest
    {
        private readonly ISubrectangleQueries _subrectangleQueries;

        public SubrectangleQueriesTest()
        {
            _subrectangleQueries = new SubrectangleQueries(new int[][] { new int[] { 1, 2, 1 }, new int[] { 4, 3, 4 }, new int[] { 3, 2, 1 }, new int[] { 1, 1, 1 } });
        }

        [Theory]
        [InlineData(0,2,1)]
        public void GetValueTest(int row, int col, int expected)
        {
            var actual = _subrectangleQueries.GetValue(row, col);
            Assert.Equal(expected, actual);
        }

        //[Theory]
        //[InlineData(0, 0, 3, 2, 5, 0, 2, 5)]
        //public void UpdateSubrectangle(int row1, int col1, int row2, int col2, int newValue, int row, int col, int expected)
        //{
        //    _subrectangleQueries.UpdateSubrectangle(row1, col1, row2, col2, newValue);
        //    var actual = _subrectangleQueries.GetValue(row, col);
        //    Assert.Equal(expected, actual);
        //}
    }
}

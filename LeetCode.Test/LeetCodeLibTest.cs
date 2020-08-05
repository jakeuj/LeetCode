using System.Collections.Generic;
using Xunit;

namespace LeetCode.Test
{
    public class LeetCodeLibTest
    {
        private readonly ILeetCodeLib _leetCodeLib;

        public LeetCodeLibTest()
        {
            _leetCodeLib = new LeetCodeLib();
        }

        [Theory]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9)]
        [InlineData(new int[] { 3, 2, 4 }, 6)]
        public void TwoSumTest(int[] nums, int expected)
        {
            var result = _leetCodeLib.TwoSum(nums, expected);
            var actual = nums[result[0]] + nums[result[1]];
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4 }, new int[] { 1, 3, 6, 10 })]
        [InlineData(new int[] { 1, 1, 1, 1, 1 }, new int[] { 1, 2, 3, 4, 5 })]
        public void RunningSumTest(int[] nums, int[] expected)
        {
            var result = _leetCodeLib.RunningSum(nums);
            var actual = result;
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 2, 5, 1, 3, 4, 7 },3, new int[] { 2, 3, 5, 4, 1, 7 })]
        [InlineData(new int[] { 1, 2, 3, 4, 4, 3, 2, 1 }, 4, new int[] { 1, 4, 2, 3, 3, 2, 4, 1 })]
        public void ShuffleTest(int[] nums, int n, int[] expected)
        {
            var result = _leetCodeLib.Shuffle(nums,n);
            var actual = result;
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 2, 3, 5, 1, 3 }, 3, new bool[] { true, true, true, false, true })]
        public void KidsWithCandiesTest(int[] nums, int n, IList<bool> expected)
        {
            var result = _leetCodeLib.KidsWithCandies(nums, n);
            var actual = result;
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 1, 1, 3 }, 4)]
        public void NumIdenticalPairsTest(int[] nums, int expected)
        {
            var result = _leetCodeLib.NumIdenticalPairs(nums);
            var actual = result;
            Assert.Equal(expected, actual);
        }
    }
}
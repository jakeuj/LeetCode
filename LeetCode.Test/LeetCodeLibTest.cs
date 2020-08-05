using System.Collections.Generic;
using System.Linq;
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
        [InlineData(new int[] { 2, 5, 1, 3, 4, 7 }, 3, new int[] { 2, 3, 5, 4, 1, 7 })]
        [InlineData(new int[] { 1, 2, 3, 4, 4, 3, 2, 1 }, 4, new int[] { 1, 4, 2, 3, 3, 2, 4, 1 })]
        public void ShuffleTest(int[] nums, int n, int[] expected)
        {
            var result = _leetCodeLib.Shuffle(nums, n);
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

        [Theory]
        [InlineData("1.1.1.1", "1[.]1[.]1[.]1")]
        public void DefangIPaddrTest(string input, string expected)
        {
            var result = _leetCodeLib.DefangIPaddr(input);
            var actual = result;
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("aA", "aAAbbbb", 3)]
        public void NumJewelsInStonesTest(string j, string s, int expected)
        {
            var result = _leetCodeLib.NumJewelsInStones(j, s);
            var actual = result;
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(14, 6)]
        public void NumberOfStepsTest(int num, int expected)
        {
            var result = _leetCodeLib.NumberOfSteps(num);
            var actual = result;
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData("codeleet", new int[] { 4, 5, 6, 7, 0, 2, 1, 3}, "leetcode")]
        public void RestoreStringTest(string s, int[] indices, string expected)
        {
            var result = _leetCodeLib.RestoreString(s, indices);
            var actual = result;
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 8, 1, 2, 2, 3 }, new int[] { 4, 0, 1, 1, 3 })]
        public void SmallerNumbersThanCurrentTest(int[] nums, int[] expected)
        {
            var result = _leetCodeLib.SmallerNumbersThanCurrent(nums);
            var actual = result;
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5,0,8)]
        [InlineData(4, 3, 8)]
        public void XorOperationTest(int n, int start, int expected)
        {
            var result = _leetCodeLib.XorOperation(n, start);
            var actual = result;
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(234, 15)]
        [InlineData(114, -2)]        
        public void SubtractProductAndSumTest(int n, int expected)
        {
            var result = _leetCodeLib.SubtractProductAndSum(n);
            var actual = result;
            Assert.Equal(expected, actual);
        }

        //DecompressRLElist
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4 }, new int[] { 2, 4, 4, 4 })]
        [InlineData(new int[] { 1, 1, 2, 3 }, new int[] { 1, 3, 3 })]
        public void DecompressRLElistTest(int[] nums, int[] expected)
        {
            var result = _leetCodeLib.DecompressRLElist(nums);
            var actual = result;
            Assert.Equal(expected, actual);
        }

        //CreateTargetArray
        [Theory]
        [InlineData(new int[] { 0, 1, 2, 3, 4 }, new int[] { 0, 1, 2, 2, 1 }, new int[] { 0, 4, 1, 3, 2 })]
        [InlineData(new int[] { 1, 2, 3, 4, 0 }, new int[] { 0, 1, 2, 3, 0 }, new int[] { 0, 1, 2, 3, 4 })]
        public void CreateTargetArrayTest(int[] nums, int[] index, int[] expected)
        {
            var result = _leetCodeLib.CreateTargetArray(nums, index);
            var actual = result;
            Assert.Equal(expected, actual);
        }
        //CheckPossibility
        [Theory]
        [InlineData(new int[] { 4, 2, 3 }, true)]
        [InlineData(new int[] { 4, 2, 1 }, false)]
        [InlineData(new int[] { 3,4,2,3}, false)]
        public void CheckPossibilityTest(int[] nums, bool expected)
        {
            var result = _leetCodeLib.CheckPossibility(nums);
            var actual = result;
            Assert.Equal(expected, actual);
        }

        //GroupThePeople
        [Theory]
        [InlineData(new int[] { 3, 3, 3, 3, 3, 1, 3 })]
        public void GroupThePeopleTest(int[] nums)
        {
            IList<IList<int>> expected = new List<IList<int>> { new List<int> { 5 }, new List<int> { 0, 1, 2 }, new List<int> { 3, 4, 6 } };
            var result = _leetCodeLib.GroupThePeople(nums);
            var actual = result;
            Assert.Equal(expected.Count(), actual.Count());
        }

        //GetTargetCopy
        //[Theory]
        //[InlineData(7, 7, 7)]
        //public void GetTargetCopyTest(int tree, int target, int expected)
        //{
        //    var result = _leetCodeLib.GetTargetCopy(tree, target);
        //    var actual = result;
        //    Assert.Equal(expected, actual);
        //}
    }
}
using System.Collections.Generic;

namespace LeetCode
{
    public interface ILeetCodeLib
    {
        // 1. Two Sum
        int[] TwoSum(int[] nums, int target);
        // 1480. Running Sum of 1d Array
        int[] RunningSum(int[] nums);
        // 1470. Shuffle the Array
        int[] Shuffle(int[] nums, int n);
        // 1431. Kids With the Greatest Number of Candies
        IList<bool> KidsWithCandies(int[] candies, int extraCandies);
        // 1512. Number of Good Pairs
        int NumIdenticalPairs(int[] nums);
    }
}
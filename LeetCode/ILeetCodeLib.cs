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
        // 1108. Defanging an IP Address
        string DefangIPaddr(string address);
        // 771. Jewels and Stones
        int NumJewelsInStones(string J, string S);
        // 1342. Number of Steps to Reduce a Number to Zero
        int NumberOfSteps(int num);
        // 1528. Shuffle String
        string RestoreString(string s, int[] indices);
        // 1365. How Many Numbers Are Smaller Than the Current Number
        int[] SmallerNumbersThanCurrent(int[] nums);
        // 1486. XOR Operation in an Array
        int XorOperation(int n, int start);
        // 1281. Subtract the Product and Sum of Digits of an Integer
        int SubtractProductAndSum(int n);
    }
}
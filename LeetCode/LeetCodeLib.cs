using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class LeetCodeLib : ILeetCodeLib
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                        return new[] { i, j };
                }
            }
            throw new Exception();
        }
        
        public int[] RunningSum(int[] nums)
        {
            List<int> result = new List<int>();
            var temp = 0;
            nums.ToList().ForEach(x =>
            {
                temp = temp + x;
                result.Add(temp);
            });
            return result.ToArray();
        }
                
        public int[] Shuffle(int[] nums, int n)
        {
            List<int> result = new List<int>();
            for(int i=0;i<2*n;i++)
            {
                if (i % 2 == 0)
                    result.Add(nums[i/2]);
                else
                    result.Add(nums[n+i/2]);
            }
            return result.ToArray();
        }

        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            var input = candies.ToList();
            List<bool> result = new List<bool>();
            var greatest = input.Max();
            input.ForEach(x => result.Add(x + extraCandies >= greatest));
            return result;
        }

        public int NumIdenticalPairs(int[] nums)
        {
            int count = 0;
            for(int i=0;i<nums.Length - 1;i++)
                for(int j=i+1;j< nums.Length;j++)
                {
                    if (nums[i] == nums[j])
                        count++;
                }
            return count;
        }
    }
}

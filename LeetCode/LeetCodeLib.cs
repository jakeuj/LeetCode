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

        public string DefangIPaddr(string address)
        {
            return address.Replace(".", "[.]");
        }

        public int NumJewelsInStones(string J, string S)
        {
            var cond = J.ToCharArray().Distinct();
            return S.ToCharArray().Count(x => cond.Contains(x));
        }

        public int NumberOfSteps(int num)
        {
            int count = 0;
            while (num > 0)
            {
                if (num % 2 == 0)
                    num /= 2;
                else
                    num -= 1;
                count++;
            }
            return count;
        }

        public string RestoreString(string s, int[] indices)
        {
            List<(int, char)> data = new List<(int, char)>();
            for (int i = 0; i < indices.Length; i++)
            {
                (int, char) t = (indices[i], s[i]);
                data.Add(t);
            }
            return new string(data.OrderBy(x => x.Item1).Select(x => x.Item2).ToArray());
        }

        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            var input = nums.ToList();
            var output = new List<int>();
            input.ForEach(x=>output.Add(input.Count(y=> y<x)));
            return output.ToArray();
        }

        public int XorOperation(int n, int start)
        {
            var output = 0x0;
            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                    output = start;
                else
                    output = output ^ (start + 2 * i);
            }
            return output;
        }

        public int SubtractProductAndSum(int n)
        {
            var product = 1;
            var sum = 0;
            while (n>=10)
            {
                var temp = n % 10;
                product *= temp;
                sum += temp;
                n = n / 10;
            }
            product *= n;
            sum += n;
            return product - sum;
        }
    }
}

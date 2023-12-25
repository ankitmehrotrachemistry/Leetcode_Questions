using System;
using System.Collections.Generic;

namespace LeetCode_1_TwoSum
{
    class Program
    {
        static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                var value = nums[i];

                for (int y = i + 1; y < nums.Length; y++)
                {
                    var result = value + nums[y];

                    if (result == target)
                    {
                        return new int[] { i, y };
                    }
                }
            }

            return null;
        }
        public static int[] TwoSum1(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        int[] result = { i, j };
                        return result;
                    }
                }
            }
            return null;
        }
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4 };
            int target = 5;

            var result1 = TwoSum(new int[] { 2, 7, 11, 15 }, 9);

            Console.WriteLine("The values are : " + result1[0] + " , " + result1[1]);

            var result2 = TwoSum1(nums, target);

            Console.WriteLine("The values are : " + result2[0] + " , " + result2[1]);

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
The values are : 0 , 1
The values are : 0 , 3
*/

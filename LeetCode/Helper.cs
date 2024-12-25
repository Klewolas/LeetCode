using System;

namespace LeetCode
{
    public static class Helper
    {
        public static void TestSummary(string testName)
        {
            Console.WriteLine($"------{testName}------");
        }

        public static string ToString(int[] nums)
        {
            string s = "[";

            for (int i = 0; i < nums.Length; i++)
            {
                s += nums[i];
                if (i < nums.Length - 1)
                    s += ",";
            }

            s += "]";
            return s;
        }
    }
}
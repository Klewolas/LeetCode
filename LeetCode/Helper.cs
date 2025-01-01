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
        
        public static string ToString(int[][] nums)
        {
            string s = "[";
            for (var i = 0; i < nums.Length; i++)
            {
                s += "[";
                for (var j = 0; j < nums[i].Length; j++)
                {
                    s += nums[i][j].ToString();
                    if (j < nums[i].Length - 1)
                        s += ",";
                }
                s += "]";
            }
            s += "]";
            return s;
        }
    }
}
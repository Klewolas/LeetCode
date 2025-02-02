using System;

namespace LeetCode
{
    public class MaximumGapQ : LeetQ
    {
        public override void TestCases()
        {
            base.TestCases();
            
            Console.WriteLine($"Test Case ([3,6,9,1]) :  : {MaximumGap(new []{3,6,9,1})}");
            Console.WriteLine($"Test Case (10) :  : {MaximumGap(new []{10})}");
        }

        private int MaximumGap(int[] nums)
        {
            if (nums.Length <= 2)
                return 0;
            
            Array.Sort(nums);

            int maxGap= 0;
            
            for (var i = 1; i < nums.Length; i++)
            {
                if (nums[i] - nums[i-1] > maxGap)
                {
                    maxGap = nums[i] - nums[i-1];
                }
            }

            return maxGap;
        }
    }
}
using System;
using System.Linq;

namespace LeetCode
{
    public class RemoveElementQ : LeetQ
    {
        public override void TestCases()
        {
            base.TestCases();

            int[] nums = new[] { 3, 2, 2, 3 };
            var result = RemoveElement(nums, 3);
            Console.WriteLine($"Test Case ([3,2,2,3], 3) : {Helper.ToString(nums)}, {result}");

            nums = new[] { 0, 1, 2, 2, 3, 0, 4, 2 };
            result = RemoveElement(nums, 2);
            Console.WriteLine($"Test Case ([0,1,2,2,3,0,4,2], 2) : {Helper.ToString(nums)}, {result}");
        }
        
        private int RemoveElement(int[] nums, int val)
        {
            int j = 0;
        
            for (int i = 0; i < nums.Length; i++) {
                if (nums[i] != val) {
                    nums[j] = nums[i];
                    j++;
                }
            }
        
            return j;
        }
    }
}
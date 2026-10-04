using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class ContainsDuplicateQ : LeetQ
    {
        public override void TestCases()
        {
            base.TestCases();
            
            Console.WriteLine($"Test Case ([1,2,3,1]) :  : {ContainsDuplicate(new []{1,2,3,1})}");
            Console.WriteLine($"Test Case ([1,2,3,4]) :  : {ContainsDuplicate(new []{1,2,3,4})}");
            Console.WriteLine($"Test Case ([1,1,1,3,3,4,3,2,4,2]) :  : {ContainsDuplicate(new []{1,1,1,3,3,4,3,2,4,2})}");
        }
        
        private bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> hashSet = new HashSet<int>(nums);

            return nums.Length != hashSet.Count;
        }
    }
}
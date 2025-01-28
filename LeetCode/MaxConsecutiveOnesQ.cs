using System;

namespace LeetCode
{
    public class MaxConsecutiveOnesQ : LeetQ
    {
        public override void TestCases()
        {
            base.TestCases();
            
            Console.WriteLine($"Test Case ([1,1,0,1,1,1]) : {FindMaxConsecutiveOnes(new []{1,1,0,1,1,1})}"); 
            Console.WriteLine($"Test Case ([1,0,1,1,0,1]) : {FindMaxConsecutiveOnes(new []{1,0,1,1,0,1})}");
        }
        
        private int FindMaxConsecutiveOnes(int[] nums)
        {
            int counter = 0;
            int maxCount = 0;
            foreach (var i in nums)
            {
                if (i == 1)
                {
                    counter++;
                    if (counter > maxCount)
                        maxCount = counter;
                }
                else
                    counter = 0;
            }

            return maxCount;
        }
    }
}
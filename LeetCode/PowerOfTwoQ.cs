using System;

namespace LeetCode
{
    public class PowerOfTwoQ : LeetQ
    {
        public override void TestCases()
        {
            base.TestCases();
            

            Console.WriteLine($"Test Case (1) :  : {IsPowerOfTwo(1)}");
            Console.WriteLine($"Test Case (16) :  : {IsPowerOfTwo(16)}");
            Console.WriteLine($"Test Case (3) :  : {IsPowerOfTwo(3)}");
        }
        
        private bool IsPowerOfTwo(int n)
        {
            if(n < 1)
                return false;
            
            return (n & (n-1)) == 0;
        }
    }
}
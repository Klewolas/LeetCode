using System;

namespace LeetCode
{
    public class PowerOfThreeQ : LeetQ
    {
        public override void TestCases()
        {
            base.TestCases();
            
            Console.WriteLine($"Test Case (27) :  : {IsPowerOfThree(27)}");
            Console.WriteLine($"Test Case (0) :  : {IsPowerOfThree(0)}");
            Console.WriteLine($"Test Case (-1) :  : {IsPowerOfThree(-1)}");
        }
        
        private bool IsPowerOfThree(int n)
        {
            int currentValue = 1;
            while (currentValue <= n)
            {
                if (currentValue == n)
                    return true;
                
                if (currentValue > int.MaxValue / 3)
                    break;

                currentValue *= 3;
            }
            return false;
        }
    }
}
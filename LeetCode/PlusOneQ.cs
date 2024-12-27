using System;
using System.Linq;

namespace LeetCode
{
    public class PlusOneQ : LeetQ
    {
        public override void TestCases()
        {
            base.TestCases();
            
            var answer = PlusOne(new[] { 9,9,9,9,9,9,9,9 });
            
            foreach (var i in answer)
            {
                Console.WriteLine($"{i}");
            }
        }

        private int[] PlusOne(int[] digits) {
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] == 9) digits[i] = 0;
                else
                {
                    digits[i]++;
                    return digits;
                }
            }
            int[] firstOne = new int[] { 1 };
            return firstOne.Concat(digits).ToArray();
        }
    }
}
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace LeetCode
{
    public class ValidPalindromeQ : LeetQ
    {
        public override void TestCases()
        {
            base.TestCases();
            
            var result = IsPalindrome("A man, a plan, a canal: Panama");
            Console.WriteLine($"Test Case (\"A man, a plan, a canal: Panama\") : {result}");
            
            result = IsPalindrome("race a car");
            Console.WriteLine($"Test Case (\"race a car\") : {result}");
            
            result = IsPalindrome("");
            Console.WriteLine($"Test Case (\"\") : {result}");
        }
        
        private bool IsPalindrome(string s)
        {
            s = s.ToLower();
            s = new string(s.Where(char.IsLetterOrDigit).ToArray());
            
            int left = 0, right = s.Length - 1;
            while (left < right)
            {
                if (s[left++] != s[right--])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
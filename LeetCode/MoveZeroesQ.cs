using System;

namespace LeetCode
{
    public class MoveZeroesQ : LeetQ
    {
        public void MoveZeroes(int[] nums)
        {
            int left = 0;

            for (var right = 0; right < nums.Length; right++)
            {
                if (nums[right] != 0)
                {
                    var temp = nums[left];
                    nums[left] = nums[right];
                    nums[right] = temp;
                    left++;
                }
            }
        }
    }
}
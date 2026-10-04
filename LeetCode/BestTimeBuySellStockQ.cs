using System;
using System.Collections;
using System.Linq;

namespace LeetCode
{
    public class BestTimeBuySellStockQ : LeetQ
    {
        public override void TestCases()
        {
            base.TestCases();
            
            Console.WriteLine($"Test Case ([7,1,5,3,6,4]) : {MaxProfit(new []{7,1,5,3,6,4})}");
            Console.WriteLine($"Test Case ([7,6,4,3,1]) : {MaxProfit(new []{7,6,4,3,1})}");
        }
        
        public int MaxProfit(int[] prices)
        {
            int minPrice = int.MaxValue;
            int maxProfit = 0;
            for (var i = 0; i < prices.Length; i++)
            {
                minPrice = Math.Min(prices[i], minPrice);
                maxProfit = Math.Max(maxProfit, prices[i] - minPrice);
            }
            
            return maxProfit;
        }
    }
}
using System;

namespace LeetCode
{
    public class MinimumOperationsStrictlyIncreasingQ : LeetQ
    {
        public override void TestCases()
        {
            base.TestCases();
            
            int[][] grid = new int[][]
            {
                new int[] {3,2},
                new int[] {1,3},
                new int[] {3,4},
                new int[] {0,1}
            };
            var result = MinimumOperations(grid);
            Console.WriteLine($"Test Case ([[3,2],[1,3],[3,4],[0,1]]) : {Helper.ToString(grid)}, Operation Count : {result}");

            grid = new int[][] 
            {
                new int[] {3,2,1},
                new int[] {2,1,0},
                new int[] {1,2,3}
            };
            result = MinimumOperations(grid);
            Console.WriteLine($"Test Case ([[3,2,1],[2,1,0],[1,2,3]]) : {Helper.ToString(grid)}, Operation Count : {result}");
        }
        
        private int MinimumOperations(int[][] grid)
        {
            var operationCount = 0;

            for (int i = 0; i < grid[0].Length; i++)
            {
                int temp = grid[0][i];
                for (int j = 1; j < grid.Length; j++)
                {
                    if (grid[j][i] <= temp)
                    {
                        var operation = temp - grid[j][i]  + 1;
                        grid[j][i] += operation;
                        operationCount += operation;
                    }
                    temp = grid[j][i];
                }
            }

            return operationCount;
        }
    }
}
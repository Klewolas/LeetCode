using System;

namespace LeetCode
{
    public class NumIslandsQ : LeetQ
    {
        public int NumIslands(char[][] grid)
        {
            var islands = 0;
            
            for (var i = 0; i < grid.Length; i++)
            {
                for (var j = 0; j < grid[0].Length; j++)
                {
                    if(grid[i][j] == '1')
                    {
                        Discover(grid, i, j, grid.Length, grid[0].Length);
                        islands++;
                    }
                }
            }

            return islands;
        }
        
        public void Discover(char[][] grid, int pointI, int pointJ, int m, int n)
        {
            grid[pointI][pointJ] = '0';

            if(pointI + 1 < m && grid[pointI + 1][pointJ] == '1')
                Discover(grid, pointI + 1, pointJ, m, n);
            
            if(pointI - 1 >= 0 && grid[pointI - 1][pointJ] == '1')
                Discover(grid, pointI - 1, pointJ, m, n);
            
            if(pointJ + 1 < n && grid[pointI][pointJ + 1] == '1')
                Discover(grid, pointI, pointJ + 1, m, n);
            
            if(pointJ - 1 >= 0 && grid[pointI][pointJ - 1] == '1')
                Discover(grid, pointI, pointJ - 1, m, n);
        }
    }
}
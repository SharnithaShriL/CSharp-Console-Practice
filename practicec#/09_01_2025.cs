using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicec_
{
    internal class _09_01_2025
    {
        //Sum of Matrix with Zero Condition
        public void sum_of_mat()
        {
            int[,] arr =
            {
                {0, 2, 3, 2},
                { 0, 6, 0, 1},
                {4, 0, 3, 0}
            };

            int sum = 0;
            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);
            for(int col = 0;col<cols;col++)
            {
                for(int row = 0;row<rows;row++)
                {
                    if (arr[row,col]==0)
                    {
                        break;
                    }
                    sum = sum + arr[row, col];
                }
            }
            Console.WriteLine(sum);
        }
        //----------------------------------
        public void sum_all_mat()
        {
            int[,] arr =
            {
                { 1, 0, 2},
                {3, 4, 0 },
                { 5, 6, 7}
            };
            int sum = 0;
            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);
            for(int col =0;col<cols;col++)
            {
                for(int row = 0;row<rows;row++)
                {
                    if (arr[row,col]==0)
                    {
                        break;
                    }
                    sum = sum + arr[row, col];
                }
            }
            Console.WriteLine(sum);
        }
        //---------------------------------------------
        public void negative_mat()
        {
            int[,] arr =
            {
                { 1, -2, 3, 4},
                { 5, 6, -7, 8},
                { 9, 10, 11, -12}
            };
            int sum = 0;
            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);
            for(int col = 0;col<cols;col++)
            {
                for(int row =0;row<rows;row++)
                {
                    if (arr[row,col]<0)
                    {
                        break;
                    }
                    sum = sum + arr[row, col];
                }
                
            }
            Console.WriteLine(sum);
        }
    }
}

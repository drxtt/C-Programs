using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepyBillu
{
    internal class Multilevel_inheritence
    {
        static void Main()
        {
            Console.Write("No. of rows for first matrix : ");
            int rows1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("No. of columns for first matrix and No. of rows for second matrix : ");
            int c1r2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("No. of columns for second matrix : ");
            int cols2 = Convert.ToInt32(Console.ReadLine());

            int[,] matrix1 = new int[rows1, c1r2];
            int[,] matrix2 = new int[c1r2, cols2];
            int[,] resultmatrix = new int[rows1, cols2];

            Console.WriteLine("Enter element of 1st Matrix : ");
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < c1r2; j++)
                {
                    Console.Write($"Element[{i},{j}] : ");
                    matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter elements of 2nd Matrix : ");
            for (int i = 0; i < c1r2; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    Console.Write($"Element [{i},{j}] : ");
                    matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for(int i=0;i<rows1; i++)
            {
                for(int j = 0;j<cols2;j++)
                {
                    for(int k = 0;k < c1r2; k++)
                    {
                        resultmatrix[i, j] = 0;
                        resultmatrix[i, j] += matrix1[i, k] * matrix2[k, j]; 
                    }
                }
            }
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    Console.Write(resultmatrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}

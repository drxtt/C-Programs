/*Write a program to input the length and breadth of a rectangle
and find its diagonal, using method diagonal=sqrt(length^2 + breadth^2)*/
using System;

namespace DiagonalLengthOfRectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LENGTH OF THE DIAGONAL OF A RECTANGLE\n");
            Console.Write("Enter the Length of the Rectangle : ");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Breadth of the Rectangle : ");
            int b = Convert.ToInt32(Console.ReadLine());

            decimal d = (decimal) Math.Sqrt(Math.Pow(l,2) + Math.Pow(b,2));
            Console.WriteLine("The Length of the Diagonal is : {0}", d);
            Console.ReadKey();
        }
    }

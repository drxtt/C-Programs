using System;

namespace DiagonalLengthOfRectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LENGTH OF THE DIAGONAL OF A RECTANGLE\n");
            Console.WriteLine("Enter the Length of the Rectangle : ");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Breadth of the Rectangle : ");
            int b = Convert.ToInt32(Console.ReadLine());

            int d = (int) Math.Sqrt(Math.Pow(l,2) + Math.Pow(b,2));
            Console.WriteLine("The Length of the Diagonal is : {0}", d);
            Console.ReadKey();
        }
    }
}

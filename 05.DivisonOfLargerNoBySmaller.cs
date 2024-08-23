/*Write a program to pass 2 integer numbers as parameters.
If either of the two numbers is 0, display invalid
entry and the program should
end, if it is valid entry, divide the larger number with the smaller
number and display the result*/
using System;

namespace DivisonOfLargerNoBySmaller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DIVISON OF LARGER NUMBER BY SMALLER NUMBER\n");
            Console.Write("Enter first number : ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number : ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 == 0 || n2 ==0)
            {
                Console.WriteLine("Invalid entry! Either of the two numbers is zero !");
            }
            else
            {
                float n3 = (float) Math.Max(n1, n2) / Math.Min(n1, n2);
                Console.WriteLine("The result of the divison is : {0}", n3);
            }
            Console.ReadKey();
        }
    }
}

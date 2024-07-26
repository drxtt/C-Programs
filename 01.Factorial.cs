using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to find its factorial : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int f=1;
            for(int i =1; i <= n; i++)
            {
                f = f * i;
            }
            Console.WriteLine("Factorial : " + f);
        }
    }
}

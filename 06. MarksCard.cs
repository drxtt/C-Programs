using System;

namespace MArksCard
{
    internal class Program
    {
        static void Main(string[] args)
        { 
        Console.Write("Enter the number of subjects : ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] num = new int[n];
        string[] sub = new string[n];
            int total, min, max;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the name of Subject {0}", i+1);
                sub[i] = Console.ReadLine();
                Console.WriteLine("Enter the marks of {0}", sub[i]);
                num[i] = Convert.ToInt32(Console.ReadLine());

                total += num[i];

                if (i == 0)
                {
                    min = max = num[i];
                    continue;
                }

                min = min > num[i] ? num[i] : min;
                max = max < num[i] ? num[i] : max;
            }
            Console.WriteLine("Total Marks : {0}", total);
            Console.WriteLine("Minimum Marks : {0} , Maximum Marks : {1}", min, max);
            Console.ReadKey();
        }
    }
}

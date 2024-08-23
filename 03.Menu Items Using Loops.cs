using System;

namespace LoopMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULATOR\nEnter Two Numbers : ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            string c;

            while (true)
            {
                Console.WriteLine("Choose Operations To Perform\n");
                Console.WriteLine("1 for Addition\n2 for Subtraction\n3 for Multiplication\n4 for Divison\n5 for Modulus\n");
                c = Console.ReadLine();
                switch (c)
                {
                    case "1":
                        Console.WriteLine("The Sum is : {0}", n1 + n2);
                        break;
                    case "2":
                        Console.WriteLine("The Difference is : {0}", n1 - n2);
                        break;
                    case "3":
                        Console.WriteLine("The Multiplication is : {0}", n1 * n2);
                        break;
                    case "4":
                        if (n2 != 0)
                            Console.WriteLine("The Divison is : {0}", n1 / n2);
                        else
                            Console.WriteLine("Number can't be divided by zero !");
                        break;
                    case "5":
                        Console.WriteLine("The Remainder is : {0}", n1 % n2);
                        break;
                    default:
                        Console.WriteLine("Invalid Input!\nPress any key for the menu!\n");
                        Console.ReadKey();
                        continue;
                }
                Console.ReadKey();
                break;
            }
        }
    }
}

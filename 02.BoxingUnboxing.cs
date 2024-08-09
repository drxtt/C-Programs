using System;
namespace BoxingUnboxing
{
 class BoxingUnboxing
 {
    static void Main(string[] args)
    {
        int num1 = 30;       //Declaring a value type
        object obj = num1;   //Boxing the value type to an object
        Console.WriteLine("Boxed element : " + obj);
        int num2 = (int)obj; //Unboxing an object type back to a value type
        Console.WriteLine("Unboxed element : " + num2);
        num1 = 50;
        Console.WriteLine("Original variable value : " + num1 + "\nBoxed element value : " + obj);
        Console.ReadKey();
        
    }
 }
}

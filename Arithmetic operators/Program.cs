using System;

namespace Arithmetic_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5, num2 = 2, result;
            result = num1 + num2;
            Console.WriteLine("Value is {0}", result);
            result = num1 - num2;
            Console.WriteLine("Value is {0}", result);
            result = num1 * num2;
            Console.WriteLine("Value is {0}", result);
            result = num1 / num2;
            Console.WriteLine("Value is {0}", result);
            result = num1 % num2;
            Console.WriteLine("Value is {0}", result);
            result = num1++;
            Console.WriteLine("Value is {0}", result);
            result = ++num1;
            Console.WriteLine("Value is {0}", result);
            result = num1--;
            Console.WriteLine("Value is {0}", result);
            result = --num1;
            Console.WriteLine("Value is {0}", result);
            Console.ReadLine();
        }
    }
}

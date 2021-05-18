using System;

namespace Logical_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 10, secondNumber = 20;
            bool result;
            result = (firstNumber == secondNumber) || (firstNumber > 5);
            Console.WriteLine(result);
            result = (firstNumber == secondNumber) && (firstNumber > 5);
            Console.WriteLine(result);
        }
    }
}

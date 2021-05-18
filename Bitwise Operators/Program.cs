using System;

namespace Bitwise_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 7;
			int secondNumber = 4;
			int result;

			result = ~firstNumber;
			Console.WriteLine("~{0} = {1}", firstNumber, result);

			result = firstNumber & secondNumber;
			Console.WriteLine("{0} & {1} = {2}", firstNumber,secondNumber, result);

			result = firstNumber | secondNumber;
			Console.WriteLine("{0} | {1} = {2}", firstNumber,secondNumber, result);

			result = firstNumber ^ secondNumber;
			Console.WriteLine("{0} ^ {1} = {2}", firstNumber,secondNumber, result);

			result = firstNumber << 1;
			Console.WriteLine("{0} << 1 = {1}", firstNumber, result);

			result = firstNumber >> 1;
			Console.WriteLine("{0} >> 1 = {1}", firstNumber, result);
        }
    }
}

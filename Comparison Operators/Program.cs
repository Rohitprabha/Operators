using System;

namespace Comparison_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
			int firstNumber = 10, secondNumber = 20;
			bool result;

			result = (firstNumber == secondNumber);
			Console.WriteLine("{0} == {1} returns {2}", firstNumber, secondNumber, result);

			result = (firstNumber > secondNumber);
			Console.WriteLine("{0} > {1} returns {2}", firstNumber, secondNumber, result);

			result = (firstNumber < secondNumber);
			Console.WriteLine("{0} < {1} returns {2}", firstNumber, secondNumber, result);

			result = (firstNumber >= secondNumber);
			Console.WriteLine("{0} >= {1} returns {2}", firstNumber, secondNumber, result);

			result = (firstNumber <= secondNumber);
			Console.WriteLine("{0} <= {1} returns {2}", firstNumber, secondNumber, result);

			result = (firstNumber != secondNumber);
			Console.WriteLine("{0} != {1} returns {2}", firstNumber, secondNumber, result);

		}
	}
}

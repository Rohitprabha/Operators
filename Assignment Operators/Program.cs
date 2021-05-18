using System;

namespace Assignment_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
			int number = 10;

			number += 5;
			Console.WriteLine(number);

			number -= 3;
			Console.WriteLine(number);

			number *= 2;
			Console.WriteLine(number);

			number /= 3;
			Console.WriteLine(number);

			number %= 3;
			Console.WriteLine(number);
		}
    }
}

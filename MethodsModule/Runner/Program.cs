using MModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Runner
{
	class Program
	{
		static void Main(string[] args)
		{
			do
			{
				Point point = new Point(ConsoleReader.ReadPointCoordinates());
				Console.WriteLine(point.ToString());
				FibonacciAndFactorial obj = new FibonacciAndFactorial();
				FibonacciAndFactorial obj1 = new FibonacciAndFactorial();
				FibonacciAndFactorial obj2 = new FibonacciAndFactorial();
				Console.WriteLine(FibonacciAndFactorial.Instance);

				FibonacciAndFactorial obj4 = new FibonacciAndFactorial();
				Console.WriteLine("Fast: " + FibonacciAndFactorial.mtx2x2.fibm(ConsoleReader.ReadNumberFibonacci()));


				Console.WriteLine(FibonacciAndFactorial.Instance);
				 
				Console.WriteLine(FibonacciAndFactorial.FactFactor(ConsoleReader.ReadNumberFactorial()));
			} while (ConsoleReader.AskToContinue().Equals("y"));
		}
	}
}

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
				//Point point = new Point(ConsoleReader.ReadPointCoordinates());
				//Console.WriteLine(point.ToString());
				FibonacciAndFactorial obj = new FibonacciAndFactorial(10);
				FibonacciAndFactorial obj1 = new FibonacciAndFactorial(10);
				FibonacciAndFactorial obj2 = new FibonacciAndFactorial(10);
				//Console.WriteLine(FibonacciAndFactorial.Instance);

				FibonacciAndFactorial obj4 = new FibonacciAndFactorial(10);
                Console.WriteLine("Fast: " + FibonacciAndFactorial.mtx2x2.fibm(ConsoleReader.ReadNumberFibonacci()));
                //Console.WriteLine("Fast: " + FibonacciAndFactorial.mtx2x2.fibm(11));
                FibonacciAndFactorial.mtx2x2.CreateSecuence(obj);
               
          ;      Console.WriteLine(obj.Sequence.Count+"&");
               // Console.WriteLine(FibonacciAndFactorial.Instance);
				 
				Console.WriteLine(FibonacciAndFactorial.FactFactor(ConsoleReader.ReadNumberFactorial()));
			} while (ConsoleReader.AskToContinue().Equals("y"));
		}
	}
}

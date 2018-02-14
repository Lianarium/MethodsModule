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
			Point point = new Point(4, 5);
			Console.WriteLine(point.ToString());
			RecursionCounter obj = new RecursionCounter();
			RecursionCounter obj1 = new RecursionCounter();
			RecursionCounter obj2 = new RecursionCounter();
			Console.WriteLine(RecursionCounter.Instance);
			int number = 200;
			RecursionCounter obj4 = new RecursionCounter();
			Console.WriteLine("Fast: " + RecursionCounter.mtx2x2.fibm(100));
			//Console.WriteLine("Slow: " + obj4.CountFibonacciSlow(number));
			//Console.WriteLine("Little Memory: " + obj4.CountFibonacciLittleMemory(number));

			Console.WriteLine(RecursionCounter.Instance);
			//BigInteger big = new BigInteger(RecursionCounter.mtx2x2.fibm(50));
			//Console.WriteLine(big);


		}
	}
}

using MModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runner
{
	class Program
	{
		static void Main(string[] args)
		{
			Point point = new Point(4, 5);
			Console.WriteLine(point.ToString());
			InfoKeeper obj = new InfoKeeper();
			InfoKeeper obj1 = new InfoKeeper();
			InfoKeeper obj2 = new InfoKeeper();
			Console.WriteLine(InfoKeeper.Instance);
			int number = 30;
			RecursionCounter obj4 = new RecursionCounter();
			Console.WriteLine(obj4.CountFibonacciSlow(number));
			Console.WriteLine(obj4.CountFibonacciLittleMemory(number));
		}
	}
}

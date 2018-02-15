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
				Point point = new Point(ReaderFromConsole.ReadPointCoordinates());
				Console.WriteLine(point.ToString());
				RecursionCounter obj = new RecursionCounter();
				RecursionCounter obj1 = new RecursionCounter();
				RecursionCounter obj2 = new RecursionCounter();
				Console.WriteLine(RecursionCounter.Instance);

				RecursionCounter obj4 = new RecursionCounter();
				Console.WriteLine("Fast: " + RecursionCounter.mtx2x2.fibm(ReaderFromConsole.ReadNumber()));


				Console.WriteLine(RecursionCounter.Instance);
				 
				//Console.WriteLine(RecursionCounter.FactFactor(50000));
			} while (ReaderFromConsole.AskToContinue().Equals("y"));
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MModule
{
	public class RecursionCounter
	{
		private int rowposition;

		public RecursionCounter()
		{
			 
		}

		public int CountFibonacciSlow(int num)
		{
			if (num < 2) return num;
			else return CountFibonacciSlow(num - 1) + CountFibonacciSlow(num - 2);

		}

		public int CountFibonacciLittleMemory(int number)
		{
			int num = 1;
			int numminone = 0;
			for (int i = 1; i < number; i++)
			{
				num += numminone;
				numminone = num - numminone;
			}
			return num;
		}


		public  int CountFactorial()
		{
			return 1;
		}

	}
}

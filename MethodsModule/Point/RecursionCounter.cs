using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace MModule
{
	public class RecursionCounter
	{
		private int rowposition;
		private static int instancenumber;

		public static int Instance
		{
			get { return instancenumber; }
		}

		public RecursionCounter()
		{
			instancenumber++;
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


		public static BigInteger IntPower(BigInteger x, short power)
		{
			if (power == 0) return 1;
			if (power == 1) return x;
			int n = 15;
			while ((power <<= 1) >= 0) n--;
			BigInteger tmp = x;
			while (--n > 0)
				tmp = tmp * tmp *
					 (((power <<= 1) < 0) ? x : 1);
			return tmp;
		}

		public struct mtx2x2
		{
			private static readonly mtx2x2 fibMtx = new mtx2x2 { _11 = 1, _12 = 1, _21 = 1 };
			private static readonly mtx2x2 identity = new mtx2x2 { _11 = 1, _22 = 1 };

			public BigInteger _11, _12, _21, _22;
			public static mtx2x2 operator *(mtx2x2 lhs, mtx2x2 rhs)
			{
				return new mtx2x2
				{
					_11 = lhs._11 * rhs._11 + lhs._12 * rhs._21,
					_12 = lhs._11 * rhs._12 + lhs._12 * rhs._22,
					_21 = lhs._21 * rhs._11 + lhs._22 * rhs._21,
					_22 = lhs._21 * rhs._12 + lhs._22 * rhs._22
				};
			}

			public static mtx2x2 IntPower(mtx2x2 x, short power)
			{
				if (power == 0) return identity;
				if (power == 1) return x;
				int n = 15;
				while ((power <<= 1) >= 0) n--;
				mtx2x2 tmp = x;
				while (--n > 0)
					tmp = (tmp * tmp) * (((power <<= 1) < 0) ? x : identity);
				return tmp;
			}

			public static BigInteger fibm(int n)
			{
				return IntPower(fibMtx, (short)(n - 1))._11;
			}

		}


	}
}


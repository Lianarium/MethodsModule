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

		public static BigInteger FactFactor(int n)
		{
			if (n < 0)
				return 0;
			if (n == 0)
				return 1;
			if (n == 1 || n == 2)
				return n;
			bool[] u = new bool[n + 1]; // маркеры для решета Эратосфена
			List<Tuple<int, int>> p = new List<Tuple<int, int>>(); // множители и их показатели степеней
			for (int i = 2; i <= n; ++i)
				if (!u[i]) // если i - очередное простое число
				{
					// считаем показатель степени в разложении
					int k = n / i;
					int c = 0;
					while (k > 0)
					{
						c += k;
						k /= i;
					}
					// запоминаем множитель и его показатель степени
					p.Add(new Tuple<int, int>(i, c));
					// просеиваем составные числа через решето               
					int j = 2;
					while (i * j <= n)
					{
						u[i * j] = true;
						++j;
					}
				}
			// вычисляем факториал
			BigInteger r = 1;
			for (int i = p.Count() - 1; i >= 0; --i)
				r *= BigInteger.Pow(p[i].Item1, p[i].Item2);
			return r;
		}
	}
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Collections;

namespace MModule
{
	public class FibonacciAndFactorial
	{
		private int number;
		private static int instancenumber;
		private ArrayList sequence;


		public ArrayList Sequence
		{
			get { return sequence; }
		}

		public int Number
		{
			set { number = value; }
			get { return number; }
		}

		public static int Instance
		{
			get { return instancenumber; }
		}

		public FibonacciAndFactorial()
		{
			instancenumber++;
			this.sequence = new ArrayList();
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
			private static readonly mtx2x2 fibMtx = new mtx2x2 { el00 = 1, el01 = 1, el10 = 1 };
			private static readonly mtx2x2 identity = new mtx2x2 { el00 = 1, el11 = 1 };

			public BigInteger el00, el01, el10, el11;

			public static mtx2x2 operator *(mtx2x2 lhs, mtx2x2 rhs)
			{
				return new mtx2x2
				{
					el00 = lhs.el00 * rhs.el00 + lhs.el01 * rhs.el10,
					el01 = lhs.el00 * rhs.el01 + lhs.el01 * rhs.el11,
					el10 = lhs.el10 * rhs.el00 + lhs.el11 * rhs.el10,
					el11 = lhs.el10 * rhs.el01 + lhs.el11 * rhs.el11
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
				return IntPower(fibMtx, (short)(n - 1)).el00;
			}

			public static FibonacciAndFactorial CreateSecuence(FibonacciAndFactorial obj)
			{
				for (int i = 1; i <= obj.Number; i++)
				{
					obj.Sequence.Add(mtx2x2.fibm(i));
				}

				return obj;
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


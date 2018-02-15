using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MModule
{
	public class ReaderFromConsole
	{
		public static double[] ReadPointCoordinates()
		{
			string[] coordinates = new string[2];
			double[] numcoordinates = new double[2];
			 
          	do
			{
				Console.WriteLine("Enter the X coordinate: ");
				coordinates[0] = Console.ReadLine();

			} while (!(double.TryParse(coordinates[0], out numcoordinates[0])));

			do
			{
				Console.WriteLine("Enter the Y coordinate: ");
				coordinates[1] = Console.ReadLine();

			} while (!(double.TryParse(coordinates[1], out numcoordinates[1])));

			return numcoordinates;
		}

		public static int ReadNumber()
		{
			string number;
			int intnumber;

			do
			{
				Console.WriteLine("Enter the number: ");
				number = Console.ReadLine();

			} while (!(int.TryParse(number, out intnumber)));

			return intnumber;
		}

		public static string AskToContinue()
		{
			string answer;
			Console.WriteLine("Continue?(y/any)");
			answer = Console.ReadLine();
			return answer;
		}

	}
}

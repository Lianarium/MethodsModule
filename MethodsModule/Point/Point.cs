using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MModule
{
	public class Point
	{
		private double x;
		private double y;

		public double X
		{
			get { return x; }
			set { x = value; }
		}

		public double Y
		{
			get { return y; }
			set { y = value; }
		}

		public Point(double[] coordinates)
		{
			x = coordinates[0];
			y = coordinates[1];
		}

		public override bool Equals(Object obj)
		{
			 
			if (obj == null || GetType() != obj.GetType())
				return false;

			Point point = (Point)obj;
			return (x == point.x) && (y == point.y);
		}

		public override string ToString()
		{
			return base.ToString() + ": (" + x.ToString() + "," + y.ToString()+")";
		}

	}
}   



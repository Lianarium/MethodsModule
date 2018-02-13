using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MModule
{
	public class InfoKeeper
	{
		private static int instancenumber;

		public static int Instance
		{
			get {return instancenumber;}
		}

		public InfoKeeper()
		{
			instancenumber++;
		}
	}
}

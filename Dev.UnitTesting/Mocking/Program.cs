using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Dev.UnitTesting.Mocking
{
	public class Program
	{
		
		public static void Main()
		{
			var services = new VideoService();
			var titlew = services.ReadVideoTitle();
			System.Console.WriteLine();
		}
	}
}

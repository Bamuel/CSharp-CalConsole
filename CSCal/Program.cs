using System;

namespace CSCal
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Type first Number");
			int n1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine ("Type second number");
			int n2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("1 - addition");
			Console.WriteLine("2 - subtration ");
			Console.WriteLine("3 - multification");
			Console.WriteLine("4 - division");
			Console.ReadKey ();
			int x = Convert.ToInt32(Console.ReadLine());
			switch (x) 
			{
			case 1:
				Console.WriteLine(n1 + n2);
				break;
			case 2:
				Console.WriteLine(n1 - n2);
				break;
			case 3:
				Console.WriteLine(n1 * n2);
				break;
			case 4:
				Console.WriteLine(n1 / n2);
				break;
			}
		}
	}
}
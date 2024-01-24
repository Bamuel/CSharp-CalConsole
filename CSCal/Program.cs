using System;
using System.Math;

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
			Console.WriteLine("2 - subtration");
			Console.WriteLine("3 - multiplication");
			Console.WriteLine("4 - division");
			Console.WriteLine("5 - power");
			Console.WriteLine("6 - sqrt");
			int x = Convert.ToInt32(Console.ReadLine());
			int answer = -100000;
			if (x==1) {
				answer = n1+n2;
			} else if (x==2) {
				answer = n1-n2;
			} else if (x==3) {
				answer = n1*n2;
			} else if (x==4) {
				answer = n1/n2;
			} else if (x==5) {
				answer = Math.Pow(n1,n2);
			} else {
				answer = Math.Sqrt(n1);
			}
		}
	}
}

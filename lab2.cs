using System;

namespace avg_simple
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int num1 = 100;
			int num2 = 200;
			int num3 = 300;
			int num4 = 400;
			int average = (num1 + num2 + num3 + num4) / 4;
			Console.WriteLine ("1st no= {0}, 2nd no= {1}, 3rd no= {2}, 4th no= {3}, avg= {4}", num1, num2, num3, num4, average);
		}
	}
}

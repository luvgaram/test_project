using System;

namespace readline
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("Write first number: ");

			string num1 = Console.ReadLine ();
			int num1_1 = int.Parse(num1);

			Console.Write ("Write second number: ");
			string num2 = Console.ReadLine ();
			int num2_1 = int.Parse(num2);
			int sum = num1_1 + num2_1;
			Console.WriteLine ("first number:{0}, second number:{1}, sum:{2}", num1_1,num2_1,sum);
		}
	}
}

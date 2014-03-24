using System;

namespace namestring
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			string greeting = "Hello, ";
			string name = "임은주";
			string result = greeting + name;

			Console.WriteLine("{0} - 문자수: {1}", result, result.Length);
		}
	}
}

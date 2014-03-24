using System;

namespace avg
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int avg1 = 100;
			int avg2 = 200;
			int avg3 = 300;
			int avg4 = 400;
			int avg = (avg1 + avg2 + avg3 + avg4) / 4;
			Console.WriteLine ("첫번째 수: {0}, 두번째 수:{1}, 세번째 수: {2}, 네번째 수:{3}, 평균: {4}", avg1, avg2, avg3, avg4, avg);
		}
	}
}

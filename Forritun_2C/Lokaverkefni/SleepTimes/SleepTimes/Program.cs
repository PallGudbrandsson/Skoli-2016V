using System;
using System.Threading;

namespace SleepTimes
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Random rand = new Random ();

			int activeNum = rand.Next (1, 100);
			int userNum = rand.Next (activeNum+5, activeNum + 15);

			while (activeNum != userNum) {
				Console.Clear ();
				Console.WriteLine ("Active Number: " + activeNum);
				Console.WriteLine ("Your number: " + userNum);

				int sleeptime = rand.Next (100, 6000);
				System.Threading.Thread.Sleep (sleeptime);
				activeNum++;
			}
			Console.WriteLine ("it's your turn");
		}
	}
}

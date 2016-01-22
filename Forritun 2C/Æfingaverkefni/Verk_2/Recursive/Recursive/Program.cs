using System;

namespace Recursive
{
	class MainClass
	{
		static void write(int num){
			Console.WriteLine(num);
		}
		static void manageWrite(int num1){
			do {
				write(num1);
				num1 = num1 - 1;
			} while (num1 != 0);
		}
		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter a starting number");
			int input = Convert.ToInt32(Console.ReadLine());

			while (input != 0) {
				manageWrite (input);
				input = input - 1;
				Console.WriteLine ();
			}
		}
	}
}
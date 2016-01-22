using System;
using System.Collections.Generic;

namespace grades
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[] splitInput = new string[2];
			string input = null;
			int num_students = 0;
			SortedDictionary<string, int> einkunnir = new SortedDictionary<string, int>();

			Console.WriteLine ("How many students do you want to insert data for");
			num_students = Convert.ToInt32(Console.ReadLine());

			for (int i = 0; i < num_students; i++) {
				Console.WriteLine ("Enter the info with the format");
				Console.WriteLine ("Student name,grade");
				input = Console.ReadLine ();
				splitInput = input.Split (',');
				einkunnir.Add (splitInput [0], Convert.ToInt32(splitInput [1]));
			}
			Console.Clear ();
			foreach (KeyValuePair<string, int> p in einkunnir)
			{
				Console.WriteLine("{0} = {1}",
					p.Key,
					p.Value);
			}
		}
	}
}

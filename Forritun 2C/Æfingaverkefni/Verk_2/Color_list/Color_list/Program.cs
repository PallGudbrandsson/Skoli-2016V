using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Color_list
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			List <string> colors = new List<string> (); 
			string input = null;

			while (input != "0") {
				Console.WriteLine ("Enter a color press 0 to exit");
				input = Console.ReadLine ();
				if (!(input == "0")) {
					colors.Add (input);
				}
			}
			input = null;
			while (input != "0") {
				Console.Clear ();
				Console.WriteLine ("0 to exit");
				Console.WriteLine ("1. Remove a color");
				Console.WriteLine ("2. Find color");
				Console.WriteLine ("3. Select colors with a spesific first letter");
				input = Console.ReadLine ();

				switch (input) {
				case "1":
					{
						Console.Clear ();

						bool inList = false;

						Console.WriteLine ("Select a color to remove");
						input = Console.ReadLine ();

						for (int i = 0; i < colors.Count; i++) {
							if (colors[i] == input) {
								inList = true;
							}
						}
						if (inList == true) {
							colors.Remove (input);
							Console.WriteLine ("{0} has been removed", input);
						} else {
							Console.WriteLine ("{0} is not in the list", input);
						}
					}
				break;
				case "2":
					{
						Console.Clear ();
						int colorIndex = 0;
						bool inList = false;

						Console.WriteLine ("Select color to find");
						input = Console.ReadLine ();

						for (int i = 0; i < colors.Count; i++) {
							if (colors[i] == input) {
								colorIndex = i;
								inList = true;
								break;
							}
						}

						if (inList) {
							Console.WriteLine ("{0} is in the list with the index {1}", input, colorIndex);
						} else {
							Console.WriteLine ("{0} is not in the list", input);
						}
					}
					break;
				case "3":
					{
						Console.Clear ();

						char startChar = 'j';
						List <int> validIndex = new List<int> ();

						Console.WriteLine ("Select a char to start with");
						input = Console.ReadLine ();
						startChar = input [0];

						for (int i = 0; i < colors.Count; i++) {
							if (colors[i][0] == startChar) {
								validIndex.Add (i);
							}
						}
						//sjáðu þetta er cool
						Console.WriteLine ("The colors that start with {0}", startChar);
						if (validIndex.Count==0) {
							Console.WriteLine ("Are 0");
						} else {
							for (int i = 0; i < validIndex.Count; i++) {
								Console.WriteLine (colors [validIndex [i]]);
							}
						}
					}
					break;
				case "0":
					break;
				default:
					Console.WriteLine ("Invalid input. Please try again");
					break;
				}//end switch
				Console.ReadLine ();
			}
		}
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verk_1
{
    class Program
    {
        public static int duplicatesLetters(string input)
        {
            SortedDictionary<char, int> repeats = new SortedDictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (repeats.ContainsKey(input[i]))
                {
                    repeats[input[i]]++;
                }
                else
                {
                    repeats.Add(input[i], 1);
                }
            }
            Console.WriteLine("Letter       amount");
            for (int i = 0; i < repeats.Count; i++)
            {
                //Console.WriteLine("{0}      {1}", i, repeats[i]);
            }
            foreach (var key in repeats.Keys)
            {
                Console.WriteLine("{0,-12}{1,-12}", key, repeats[key]);
            }
            return repeats.Count;
        }
        public static int duplicatesWords(string input)
        {
            SortedDictionary<string, int> repeats = new SortedDictionary<string, int>();
            string[] words = input.Split(' ');
            int numRepeats = 0;//counts the number of repeats

            for (int i = 0; i < words.Length; i++)
            {
                if (repeats.ContainsKey(words[i]))
                {
                    repeats[words[i]]++;
                }
                else
                {
                    repeats.Add(words[i], 0);
                }
            }
            foreach (var amount in repeats.Values)
            {
                numRepeats =numRepeats + amount;
            }
            return numRepeats;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sentence");
            string input = Console.ReadLine().ToLower();

            Console.WriteLine("There are {0} repeats in your text", duplicatesWords(input));
            Console.WriteLine();
            Console.WriteLine("counting the occurance of each letter");

            duplicatesLetters(input);

            Console.ReadLine();

        }
    }
}

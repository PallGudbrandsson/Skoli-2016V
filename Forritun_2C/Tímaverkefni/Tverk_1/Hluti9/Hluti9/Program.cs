using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hluti9
{
    class Program
    {
        static bool win = false;
        static string guess(int number, int guess)
        {
            if (number < guess)
            {
                return guess + " is to high. Try again.";
            }
            else if (guess < number)
            {
                return guess + " is to low. Try again.";
            }
            else
            {
                return "Congratulations. You guessed the number";
                win = true;
            }
        }
        static void Main(string[] args)
        {
            Random rand = new Random();
            bool win = false;
            int input = 1;

            while (input != 0)
            {
                Console.WriteLine("Guess a number between 1 and 1000");
                win = false;
                int number = rand.Next(1, 1001);
                
                while (win == false)
                {
                    Console.WriteLine("Guess (0 to exit)");
                    input = Convert.ToInt32(Console.ReadLine());

                    if (input != 0)
                    {
                        Console.WriteLine(guess(number, input));
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}

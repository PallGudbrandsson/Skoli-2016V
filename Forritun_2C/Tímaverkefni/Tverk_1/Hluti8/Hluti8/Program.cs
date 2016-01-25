using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hluti8
{
    class Program
    {
        static int heads = 0;
        static int tails = 0;
        static void kast()
        {
            Random rand = new Random();
            int toss = rand.Next(1, 3);

            if (toss==1)
            {
                heads++;
            }
            else
            {
                tails++;
            }
            Console.WriteLine("Heads: {0}, Tails: {1}", heads, tails);
        }
        static void Main(string[] args)
        {
            int choice = 0; 
            
            while (choice != 2)
            {
                Console.WriteLine("1. Toss coin");
                Console.WriteLine("2. Exit");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    kast();
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hluti2
{
    class Program
    {
        static bool margfeldi(int tala1, int tala2)
        {
            if (tala2 % tala1 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        static void Main(string[] args)
        {
            int tala1 = 1, tala2 = 0;

            while (tala1 != 0)
            {
                Console.WriteLine("Enter first number (0 to exit)");
                tala1 = Convert.ToInt32(Console.ReadLine());

                if (tala1 != 0)
                {
                    Console.WriteLine("Enter second number");
                    tala2 = Convert.ToInt32(Console.ReadLine());

                    if (margfeldi(tala1, tala2))
                    {
                        Console.WriteLine("{0} is a multible of {1}", tala2, tala1);
                    }
                    else
                    {
                        Console.WriteLine("{0} is not a multible of {1}", tala2, tala1);
                    }
                }
            }
        }
    }
}

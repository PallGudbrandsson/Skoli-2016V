using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hluti5
{
    class Program
    {
        static double area(int radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        static void Main(string[] args)
        {
            int input = 0;

            while (input >= 0)
            {
                Console.Clear();
                Console.WriteLine("Enter the radius (negative to quit):");
                input = Convert.ToInt32(Console.ReadLine());

                if (input >= 0)
                {
                    Console.WriteLine("Area is " + (area(input)).ToString("F5"));
                    Console.ReadLine();
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static double temp(int heat, int choice)
        {
            if (choice ==1)
            {
                return (heat - 32) * 5/9;
            }
            else
            {
                return heat * 1.8 + 32;
            }
        }

        static void Main(string[] args)
        {
            int heat = 0, choice = 0;
            double other = 0;

            while (choice != 3)
            {
                Console.Clear();
                Console.WriteLine("1. Fahrenheit to Celsius");
                Console.WriteLine("2. Celsius to Fahrenheit");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Enter choice");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice==1)
                {
                    Console.WriteLine("Enter Fahrenheit temperature:");
                    heat = Convert.ToInt32(Console.ReadLine());

                    other = temp(heat, choice);
                    Console.WriteLine("{0} Fahrenheit is {1} Celsius", heat, other);
                    Console.ReadLine();
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Enter Celsius temperature:");
                    heat = Convert.ToInt32(Console.ReadLine());

                    other = temp(heat, choice);
                    Console.WriteLine("{0} Celcius is {1} Fahrenheit", heat, other);
                    Console.ReadLine();
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hluti4
{
    class Program
    {
        static void write(int length)
        {
            string writer = null;

            for (int i = 0; i < length; i++)
            {
                writer += '*';
            }

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(writer);
            }
        }
        static void Main(string[] args)
        {
            int lenght = 1;

            while (lenght != 0)
            {
                Console.Clear();
                Console.WriteLine("Enter length 0 to quit");
                lenght = Convert.ToInt32(Console.ReadLine());

                if (lenght != 0)
                {
                    write(lenght);
                    Console.ReadLine();
                }
            }
        }
    }
}

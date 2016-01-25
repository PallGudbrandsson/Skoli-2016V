using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hluti7
{
    class Program
    {
        static int min(int[] num)
        {
            return num.Min();
        }
        static void Main(string[] args)
        {
            int[] num = new int[3];
            while (true)
            {
                Console.Clear();
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Enter number " + (i + 1));
                    num[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("The smallest number is " + min(num));
                Console.ReadLine();
            }
        }
    }
}

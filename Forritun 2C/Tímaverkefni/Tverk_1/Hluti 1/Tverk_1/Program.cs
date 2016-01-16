using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tverk_1
{
    class Program
    {
        static double reikna(double hlid1, double hlid2){
            double summa = 0;

            summa = Math.Pow(hlid1, 2) + Math.Pow(hlid2, 2);
            summa = Math.Sqrt(summa);
            return summa;
        }
        static void Main(string[] args)
        {
            double tala1 = 0, tala2 = 0;
            while (tala1 >= 0)
            {
                Console.WriteLine("Enter side 1 (negative to quit):");
                tala1 = Convert.ToDouble(Console.ReadLine());
                if (tala1 >=0)
                {
                    Console.WriteLine("Enter side 2:");
                    tala2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Hypothenuse is: " + (reikna(tala1, tala2)).ToString("F3"));
                }
            }
        }
    }
}

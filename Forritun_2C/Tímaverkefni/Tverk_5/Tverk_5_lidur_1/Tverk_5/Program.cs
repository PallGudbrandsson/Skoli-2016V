using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tverk_5
{
    class Program
    {
        static void Main(string[] args)
        {
            bicicle bike = new bicicle(50, 3, 20);

            mountainbike Mbike = new mountainbike(50, 3, 20, 50);

            roadbike Rbike = new roadbike(50, 3, 20, true);

            tandembike Tbike = new tandembike(50, 3, 20, 60);

            Console.WriteLine("Bike");
            Console.WriteLine(bike);
            Console.WriteLine();
            Console.WriteLine("Mountqain bike");
            Console.WriteLine(Mbike);
            Console.WriteLine();
            Console.WriteLine("Road bike");
            Console.WriteLine(Rbike);
            Console.WriteLine();
            Console.WriteLine("Tandem bike");
            Console.WriteLine(Tbike);

            Console.ReadKey();
        }
    }
}

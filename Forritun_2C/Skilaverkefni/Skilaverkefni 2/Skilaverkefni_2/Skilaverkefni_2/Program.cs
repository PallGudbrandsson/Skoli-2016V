using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Skilaverkefni_2
{
    class Program
    {
        static void Main(string[] args)
        {
            CD cd = new CD("Jón", 5, "engin", false, 50, "Hæ");
            Console.WriteLine(cd.info());

            Console.WriteLine();

            DVD dvd = new DVD("Kalli", "None", true, 120, "Avatart");
            Console.WriteLine(dvd.info());

            Console.WriteLine();

            Package pakki1 = new Package("Palli", "Svoluhofdi 2", "moso", "Katrin", "Leyndo", "Leyndo", 10, 20);
            Console.WriteLine(pakki1.info());

            Console.WriteLine();

            twoDay pakki2 = new twoDay(50,"Palli", "Svoluhofdi 2", "moso", "Katrin", "Leyndo", "Leyndo", 10, 20);
            Console.WriteLine(pakki2.info());

            Console.WriteLine();

            overNight pakki3 = new overNight(50, "Palli", "Svoluhofdi 2", "moso", "Katrin", "Leyndo", "Leyndo", 10, 20);
            Console.WriteLine(pakki3.info());

            Console.ReadLine();
        }
    }
}

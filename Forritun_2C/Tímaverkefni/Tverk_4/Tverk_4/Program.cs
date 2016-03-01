using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tverk_4
{
    class Program
    {
        static void Main(string[] args)
        {
            spendyr kkapi = new spendyr(true, "kk", true, "Adan", 115, 4);
            spendyr kvkapi = new spendyr(true, "kvk", true, "Adamína", 100, 5);
            spendyr madur = new spendyr(false, "kk", true, "Konni", 185, 2);
            spendyr hundur = new spendyr(true, "kvk", true, "Konna", 50, 8);

            kkapi.showInfo();

            madur.showInfo();

            hundur.showInfo();

            Console.ReadKey();
            //Dýr
                //Spendýr
                    //Api
                    //Maður
                    //Hundur
                //Skordýr
                    //maur
                    //könguló
        }
    }
}

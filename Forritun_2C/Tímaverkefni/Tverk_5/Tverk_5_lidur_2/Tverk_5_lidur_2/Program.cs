using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tverk_5_lidur_2
{
    class Program
    {
        static void Main(string[] args)
        {
            grunnskolanemi hjortur = new grunnskolanemi("2106058888", "1214567", "Hjortur", "KK", "Svöluhöfði 2", "á ekki", "Guðbrandur Pálsson", "Lágafellsskóli");
            Framhaldskolanemi steinunn = new Framhaldskolanemi("1510004561", "8474499", "Steinunn", "KVK", "Svöluhöfði 2", "steina15@gmail.com", "Almenn", false);
            haskolanemi palli = new haskolanemi("2410982069", "8497780", "Palli", "KK", "Svöluhöfði 2", "gudbrandsson74@gmail.com", "Master", false);

            hjortur.showInfo();

            steinunn.showInfo();

            palli.showInfo();

            Console.ReadKey();
        }
    }
}

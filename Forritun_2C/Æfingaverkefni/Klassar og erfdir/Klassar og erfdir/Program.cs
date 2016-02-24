using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassar_og_erfdir
{
    class Program
    {
        static void Main(string[] args)
        {
            Bill bill = new Bill("Bíll", "1977", 10);
            Bill bill1 = new Bill("Bíll", "1980", 10);

            Bill[] bilfylki = new Bill[2];
            bilfylki[0] = bill;
            bilfylki[1] = bill1;
            foreach (var item in bilfylki)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("Notaður listi");
            List<Bill> bilar = new List<Bill>();
            bilar.Add(bill);
            bilar.Add(bill1);
            foreach (var item in bilar)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("Uppýsingar um bílinn{0}, hvað komast margir í bílinn {1}", bill, bill.Heildarfarþegafjoldi());

            Flugvel flugvel = new Flugvel("Flugvel", "1910", 4);
            Console.WriteLine("Upplýsingar um flugvélina {0}, hvað komast margir í flugvélina: {1}", flugvel, flugvel.Heildarfarþegafjoldi());

            volvo volvo = new volvo("1980", "volvo station", 20, 4, "1452365");
            Console.WriteLine(volvo);

            Console.ReadKey();
        }
    }
}

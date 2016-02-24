using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassar_og_erfdir
{
    class Bill : Farataeki
    {
        public Bill(string brand, string age, double howmanypassenger):base(brand,age)
        {
            hveMargirKomastIbilinn = howmanypassenger;
        }
        public double hveMargirKomastIbilinn { get; set; }

        public override double Heildarfarþegafjoldi()
        {
            return hveMargirKomastIbilinn * base.Heildarfarþegafjoldi();
        }
        public override string ToString()
        {
            return base.ToString()+"konni";
        }
    }
}

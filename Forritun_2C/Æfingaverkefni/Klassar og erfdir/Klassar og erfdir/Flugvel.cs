using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassar_og_erfdir
{
    class Flugvel : Farataeki
    {
        public Flugvel(string brand, string age, double howManyPassenger)
            : base(brand, age)
        {
            hveMargirKomastIflugevelina = howManyPassenger;
        }

        public double hveMargirKomastIflugevelina { get; set; }

        public override double Heildarfarþegafjoldi()
        {
            return 100* hveMargirKomastIflugevelina * base.Heildarfarþegafjoldi();
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}

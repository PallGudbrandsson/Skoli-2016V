using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassar_og_erfdir
{
    class Farataeki
    {
        private string argerd;
        private string tegund;

        public string Argerd
        {
            get
            {
                return argerd;
            }
        }

        public string Tegund
        {
            get
            {
                return tegund;
            }
        }
        public Farataeki(string brand, string age)
        {
            argerd = age;
            tegund = brand;
        }
        public virtual double Heildarfarþegafjoldi()
        {
            return 1;
        }
        public override string ToString()
        {
            return string.Format("Tegund faratækis: {0} Argerð: {1}", Tegund, Argerd);
        }
    }
}

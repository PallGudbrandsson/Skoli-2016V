using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassar_og_erfdir
{
    class volvo : Bill
    {
        private int dekkjafjoldi;
        private string oryggisnumer;

        public volvo(string brand, string age, double howmany, int dfjoldi, string oryggisnr)
            : base(age, brand, howmany)

        {
            dekkjafjoldi = dfjoldi;
            oryggisnumer = oryggisnr;
        }
        public override string ToString()
        {
            return "Erum að prufa hérna auka klasa " +  base.ToString();
        }
    }
}

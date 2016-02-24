using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassar_og_erfdir
{
    class Skip : Farataeki
    {
        public Skip(string brand, string age, string name)
            : base(brand, age)
        {
            nafn = name;
        }

        public string nafn { get; set; }

        public override double Heildarfarþegafjoldi()
        {
            return 1000*  base.Heildarfarþegafjoldi();
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}

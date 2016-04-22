using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class vinabraud : bakkelsi
    {
        private bool serbakad;

        public vinabraud(bool ser, bool s, string b, int v, int m, string n)
            : base(s, b, v, m, n)
        {
            serbakad = ser;
        }

        public bool Serbakad
        {
            get
            {
                return serbakad;
            }
        }
    }
}

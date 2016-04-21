using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class kleinuhringur : bakkelsi
    {
        private bool holMidja;
        private string ofana;

        public kleinuhringur(bool h, string o, bool s, string b, int v, int m, string n)
            : base(s, b, v, m, n)
        {
            holMidja = h;
            ofana = o;
        }

        public bool HolMidja
        {
            get
            {
                return holMidja;
            }
        }
        public string Ofana
        {
            get
            {
                return ofana;
            }
        }
    }
}

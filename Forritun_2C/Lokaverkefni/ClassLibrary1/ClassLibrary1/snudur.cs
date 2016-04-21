using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class snudur : bakkelsi
    {
        private string ofana;
        public snudur(string o, bool s, string b, int v, int m, string n)
            : base(s, b, v, m, n)
        {
            ofana = o;
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

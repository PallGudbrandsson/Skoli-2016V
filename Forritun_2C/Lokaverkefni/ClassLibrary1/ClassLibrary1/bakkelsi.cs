using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class bakkelsi : soluvara
    {
        private bool sykurlaus;
        private string bokunarStadur;

        public bool Sykurlaus
        {
            get
            {
                return sykurlaus;
            }
        }
        public string BokunarStadur
        {
            get
            {
                return bokunarStadur;
            }
        }

        public bakkelsi (bool s, string b, int v, int m, string n)
            : base(v, m, n)
        {
            sykurlaus = s;
            bokunarStadur = b;
        }
    }
}

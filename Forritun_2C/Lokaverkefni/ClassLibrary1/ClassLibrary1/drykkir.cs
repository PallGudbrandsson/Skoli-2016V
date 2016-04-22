using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class drykkir : soluvara
    {
        private bool afengur;
        private bool sykurlaus;
        private int staerdml;


        public bool Afengur
        {
            get
            {
                return afengur;
            }
        }
        public bool Sykurlaus
        {
            get
            {
                return sykurlaus;
            }
        }
        public int Staerdml
        {
            get
            {
                return staerdml;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class braud : bakkelsi
    {
        private string tegundHveitis;
        private bool sneidad;
        private int fjoldiSneida;

        public braud(string t, bool sn, int f, bool s, string b, int v, int m, string n)
            : base(s, b, v, m, n)
        {
            tegundHveitis = t;
            sneidad = sn;
            fjoldiSneida = f;
        }
        public string TegundHveitis
        {
            get
            {
                return tegundHveitis;
            }
        }
        public bool Sneidad
        {
            get
            {
                return sneidad;
            }
        }
        public int FjoldiSneida
        {
            get
            {
                return fjoldiSneida;
            }
        }
    }
}

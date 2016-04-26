using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class sala : Iinit
    {
        private double verd;
        private int fjoldiVara;
        private string nafn;
        private string afslattakodi;
        private double afslattur;

        public sala(double v, int f, string n, string a)
        {
            verd = v;
            fjoldiVara = f;
            nafn = n;
            afslattakodi = a;
        }

        public double Verd
        {
            get
            {
                return verd;
            }
            set
            {
                if (value < 0)
                {

                }
                else
                {
                    verd = value;
                }
            }
        }
        public int FjoldiVara
        {
            get
            {
                return fjoldiVara;
            }
            set
            {
                if (value < 0)
                {

                }
                else
                {
                    fjoldiVara = value;
                }
            }
        }
        public string Nafn
        {
            get
            {
                return nafn;
            }
        }

        public void init()
        {
            afslattur = 1;
            if (afslattakodi == "Bakari2016")
            {
                //10 %
                afslattur = 0.9;
            }
        }
        public double klara()
        {
            return verd * afslattur;
        }
    }
}

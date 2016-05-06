using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class soluvara : Iinit
    {
        private int verd;
        private int magn;
        private string nafn;

        public soluvara(int v, int m, string n)
        {
            Verd = v;
            Magn = m;
            nafn = n;
        }

        public void init()
        {
            Random rand = new Random();
            magn = rand.Next(1, 50);
        }

        public int Verd
        {
            get
            {
                return verd;
            }
            set
            {
                verd = value;
            }
        }
        public string Nafn
        {
            get
            {
                return nafn;
            }
        }
        public int Magn
        {
            get
            {
                return magn;
            }
            set
            {
                magn = value;
            }
        }
    }
}

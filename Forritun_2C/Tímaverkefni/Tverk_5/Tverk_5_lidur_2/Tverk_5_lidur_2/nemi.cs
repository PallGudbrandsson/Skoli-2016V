using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tverk_5_lidur_2
{
    class nemi
    {
        private string kennitala;
        private string simanumer;
        private string nafn;
        private string kyn;
        private string heimilisfang;
        private string netfang;

        public nemi(string kt, string nr, string name, string sex, string address, string email)
        {
            kennitala = kt;
            simanumer = nr;
            nafn = name;
            kyn = sex;
            heimilisfang = address;
            netfang = email;
        }
        public virtual void showInfo()
        {
            Console.WriteLine("Kennitala: " + kennitala);
            Console.WriteLine("Nafn: " + nafn);
            Console.WriteLine("Simanumer " + simanumer);
            Console.WriteLine("Kyn: " + kyn);
            Console.WriteLine("Heimilisfang " + heimilisfang);
            Console.WriteLine("Netfang: " + netfang);
        }

    }
}

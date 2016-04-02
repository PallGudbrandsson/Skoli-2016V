using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tverk_5_lidur_2
{
    class grunnskolanemi : nemi
    {
        private string kennitala;
        private string simanumer;
        private string nafn;
        private string kyn;
        private string heimilisfang;
        private string netfang;
        private string forradamadur;
        private string nafnskola;

        public grunnskolanemi(string kt, string nr, string name, string sex, string address, string email, string foreldri, string skoli)
            : base(kt, nr, name, sex, address, email)
        {
            kennitala = kt;
            simanumer = nr;
            nafn = name;
            kyn = sex;
            heimilisfang = address;
            netfang = email;
            forradamadur = foreldri;
            nafnskola = skoli;
        }

        public override void showInfo()
        {
            Console.WriteLine("Nafn Forráðamans: " + forradamadur);
            Console.WriteLine("Nafn skóla: " + nafnskola);
            base.showInfo();
        }
    }
}

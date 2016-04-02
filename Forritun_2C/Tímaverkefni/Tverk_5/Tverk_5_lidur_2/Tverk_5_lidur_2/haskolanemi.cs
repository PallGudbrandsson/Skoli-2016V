using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tverk_5_lidur_2
{
    class haskolanemi : nemi
    {
        private string kennitala;
        private string simanumer;
        private string nafn;
        private string kyn;
        private string heimilisfang;
        private string netfang;
        private string stignams;
        private bool namslan;

        public haskolanemi(string kt, string nr, string name, string sex, string address, string email, string stig, bool lan)
            : base(kt, nr, name, sex, address, email)
        {
            kennitala = kt;
            simanumer = nr;
            nafn = name;
            kyn = sex;
            heimilisfang = address;
            netfang = email;
            stignams = stig;
            namslan = lan;
        }
        public override void showInfo()
        {
            Console.WriteLine(nafn + " er á {0} námstigi", stignams);
            if (namslan == true)
            {
                Console.WriteLine("og er með námslán");
            }
            else
            {
                Console.WriteLine("og er ekki með námslán");
            }
            base.showInfo();
        }
    }
}

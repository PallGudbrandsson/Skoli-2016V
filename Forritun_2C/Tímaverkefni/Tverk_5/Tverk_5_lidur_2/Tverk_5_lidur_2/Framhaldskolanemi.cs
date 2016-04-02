using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tverk_5_lidur_2
{
    class Framhaldskolanemi : nemi
    {
        private string kennitala;
        private string simanumer;
        private string nafn;
        private string kyn;
        private string heimilisfang;
        private string netfang;
        private string brautarheiti;
        private bool buseturstyrkur;

        public Framhaldskolanemi(string kt, string nr, string name, string sex, string address, string email, string braut, bool styrkur)
            : base(kt, nr, name, sex, address, email)
        {
            kennitala = kt;
            simanumer = nr;
            nafn = name;
            kyn = sex;
            heimilisfang = address;
            netfang = email;
            brautarheiti = braut;
            buseturstyrkur = styrkur;
        }
        public override void showInfo()
        {
            Console.WriteLine("{0} er á {1}", nafn, brautarheiti);
            if (buseturstyrkur == true)
            {
                Console.WriteLine("og er með búsetustyrk");
            }
            else
            {
                Console.WriteLine("og er ekki með búsetustyrk");
            }
            base.showInfo();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tverk_4
{
    class Dyr
    {
        private bool lifandi;
        private string kyn;
        private bool augu;


        public Dyr(bool alive, string sex, bool eyes)
        {
            lifandi = alive;
            kyn = sex;
            augu = eyes;
        }
        public virtual void showInfo()
        {
            if (lifandi == true)
            {
                Console.WriteLine("Dyrid er lyfandi af kyninu {0}", kyn);
            }
            else
            {
                Console.WriteLine("Dyrid er dautt af kyninu {0}", kyn);
            }
            if (augu == true)
            {
                Console.WriteLine("og er með augu");
            }
            else
            {
                Console.WriteLine("og er ekki með augu");
            }
        }
    }
}

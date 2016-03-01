using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tverk_4
{
    class spendyr : Dyr
    {
        private int haed;
        private int fjoldiSpena;
        private string nafn;
        private bool lifandi;
        private string kyn;
        private bool augu;


        public spendyr(bool alive, string sex, bool eyes, string name, int height, int spenar)
            :base(alive, sex, eyes)
        {
            nafn = name;
            haed = height;
            fjoldiSpena = spenar;
            lifandi = alive;
            kyn = sex;
            augu = eyes;
        }
        public override void showInfo()
        {
            Console.WriteLine("Þetta dýr heitir " +nafn+" og er "+haed.ToString()+" cm á hæð og er með "+fjoldiSpena.ToString()+" spena");
            base.showInfo();
        }
    }
}

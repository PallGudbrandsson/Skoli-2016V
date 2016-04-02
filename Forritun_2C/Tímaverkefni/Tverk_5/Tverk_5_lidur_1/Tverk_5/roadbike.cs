using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tverk_5
{
    class roadbike : bicicle
    {
        private int snuningar;
        private int gear;
        private int speed;
        private bool dropHandleBars;

        public int Snungingar
        {
            get
            {
                return snuningar;
            }
            set
            {
                snuningar = value;
            }
        }
        public int Gear
        {
            get
            {
                return gear;
            }
            set
            {
                gear = value;
            }
        }
        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                if (speed - value <= 0)
                {
                    speed = 0;
                }
                else
                {
                    speed = value;
                }
            }
        }
        public bool DropHandleBars
        {
            get
            {
                return dropHandleBars;
            }
            set
            {
                dropHandleBars = value;
            }
        }

        public roadbike(int rpm, int gyr, int hradi, bool handfong)
            : base(rpm, gyr, hradi)
        {
            Snungingar = rpm;
            Gear = gyr;
            Speed = hradi;
            DropHandleBars = handfong;
        }
        public override string ToString()
        {
            return string.Format("Cadence: {0}\nGear: {1}\nSpeed: {2}\nHandlebars: {3}", snuningar, gear, speed, dropHandleBars);
        }
    }
}

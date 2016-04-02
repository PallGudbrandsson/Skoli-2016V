using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tverk_5
{
    class tandembike : bicicle
    {
        private int snuningar;
        private int gear;
        private int speed;
        private int heigt;

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
        public int Height
        {
            get
            {
                return heigt;
            }
            set
            {
                if (value > 50)
                {
                    heigt = value;
                }
            }
        }

        public tandembike(int rpm, int gyr, int hradi, int haed)
            : base(rpm,gyr,hradi)
        {
            Snungingar = rpm;
            Gear = gyr;
            Speed = hradi;
            Height = haed;
        }

        public override string ToString()
        {
            return string.Format("Cadence: {0}\nGear: {1}\nSpeed: {2}", snuningar, gear, speed);
        }
    }
}

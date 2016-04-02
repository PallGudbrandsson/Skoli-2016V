using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tverk_5
{
    class bicicle
    {
        private int snuningar;
        private int gear;
        private int speed;

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

        public bicicle(int rpm, int gyr, int hradi)
        {
            Snungingar = rpm;
            Gear = gyr;
            Speed = hradi;
        }

        public void applyBrake(int num)
        {
            Console.WriteLine("Slow it down by {0}", num);
            Speed = speed - num;
        }
        public void speedUp(int num)
        {
            Console.WriteLine("Speed it ub by {0}", num);
            Speed = speed + num;
        }
        public override string ToString()
        {
            return string.Format("Cadence: {0}\nGear: {1}\nSpeed: {2}", snuningar, gear, speed);
        }
    }
}

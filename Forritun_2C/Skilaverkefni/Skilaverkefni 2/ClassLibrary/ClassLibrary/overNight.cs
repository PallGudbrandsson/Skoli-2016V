using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class overNight : Package
    {
        private double fee;
        public double Fee
        {
            get
            {
                return fee;
            }
            set
            {
                fee = value;
            }
        }
        public overNight(double f, string sn, string sa, string sc, string rn, string ra, string rc, double w, double p)
            : base(sn,sa,sc,rn,ra,rc,w,p)
        {
            Fee = f;
        }
        public override double cost()
        {
            return Weight * (Price + Fee);
        }
        public override string info(string type = "Over Night\n")
        {
            return base.info(type);
        }
    }
}

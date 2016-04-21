using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class twoDay : Package
    {
        public twoDay(double f, string sn, string sa, string sc, string rn, string ra, string rc, double w, double p)
            : base(sn,sa,sc,rn,ra,rc,w,p)
        {
            Fee = f;
        }
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
        public override double cost()
        {
            return base.cost() + fee;
        }
        public override string info(string type = "Two Day\n")
        {
            return base.info(type);
        }
    }
}

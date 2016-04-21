using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Package
    {
        private string sname;
        private string saddress;
        private string scounty;
        private string rname;
        private string raddress;
        private string rcounty;
        private double weight;
        private double price;

        public Package(string sn, string sa, string sc, string rn, string ra, string rc, double w, double p)
        {
            Sname = sn;
            Saddress = sa;
            Scounty = sc;
            Rname = rn; 
            Raddress = ra;
            Rcounty = rc;
            Weight = w;
            Price = p;
        }

        public virtual string info(string type = "Normal\n")
        {
            return string.Format(type + "Sender : {0}\n{1} {2}\nRecipiant : {3}\n{4} {5}\nPrice: {6}", Sname, Saddress, Scounty, Rname, Raddress, Rcounty, cost());
        }

        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        public string Rname
        {
            get
            {
                return rname;
            }
            set
            {
                rname = value;
            }
        }
        public string Raddress
        {
            get
            {
                return raddress;
            }
            set
            {
                raddress = value;
            }
        }
        public string Rcounty
        {
            get
            {
                return rcounty;
            }
            set
            {
                rcounty = value;
            }
        }
        public string Sname
        {
            get
            {
                return sname;
            }
            set
            {
                sname = value;
            }
        }
        public string Saddress
        {
            get
            {
                return saddress;
            }
            set
            {
                saddress = value;
            }
        }
        public string Scounty
        {
            get
            {
                return scounty;
            }
            set
            {
                scounty = value;
            }
        }
        public virtual double cost (){
            return Weight * Price;
        }
    }
}

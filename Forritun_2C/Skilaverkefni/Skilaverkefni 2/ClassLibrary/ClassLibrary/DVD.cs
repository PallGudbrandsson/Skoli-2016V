using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class DVD : item
    {
        private string director;
        public string Director
        {
            get
            {
                return director;
            }
            set
            {
                director = value;
            }
        }
        public DVD(string d, string c, bool g, int p, string t)
            : base(c, g, p, t)
        {
            Director = d;
        }
        public override string info(string plus = null)
        {
            plus = string.Format("Director: {0}\n", Director);
            return base.info(plus);
        }
    }
}

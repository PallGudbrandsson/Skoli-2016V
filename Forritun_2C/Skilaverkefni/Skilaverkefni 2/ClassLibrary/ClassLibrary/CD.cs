using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class CD : item
    {
        private string artist;
        public string Artist
        {
            get
            {
                return artist;
            }
            set
            {
                artist = value;
            }
        }
        private int numTracks;
        public int NumTracks
        {
            get
            {
                return numTracks;
            }
            set
            {
                numTracks = value;
            }
        }
        public CD(string a, int n, string c, bool g, int p, string t)
            : base(c, g, p, t)
        {
            Artist = a;
            NumTracks = n;
        }
        public override string info(string plus = null)
        {
            string add = string.Format("Artist: {0}\nNumber of Tracks: {1}\n", Artist, NumTracks);
            return base.info(add);
        }
    }
}

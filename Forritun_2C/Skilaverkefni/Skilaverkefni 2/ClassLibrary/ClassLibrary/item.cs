using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class item
    {
        private string comment;
        public string Comment
        {
            get
            {
                return comment;
            }
            set
            {
                comment = value;
            }
        }
        private bool gotIt;
        public bool GotIt
        {
            get
            {
                return gotIt;
            }
            set
            {
                gotIt = value;
            }
        }
        private int playingTime;
        public int PlayingTime
        {
            get
            {
                return playingTime;
            }
            set
            {
                playingTime = value;
            }
        }
        private string title;
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        public item(string c, bool g, int p, string t)
        {
            Comment = c;
            GotIt = g;
            PlayingTime = p;
            Title = t;
        }
        public virtual string info(string plus = null)
        {
            return string.Format(plus+"Title: {0}\nRuntime: {1}\nComments: {2}\n rented {3}", Title, PlayingTime, Comment, GotIt.ToString());
        }
    }
}

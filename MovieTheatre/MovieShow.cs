using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheatre
{
    public class MovieShow
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string MovieName { get; set; }

        public override string ToString()
        {
            return "Movie: " + MovieName + "\nStart: " + Start + "\nEnd: " + End;
        }
    }
}

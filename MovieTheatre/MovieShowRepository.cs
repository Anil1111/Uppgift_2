using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheatre
{
    class MovieShowRepository
    {
        private List<MovieShow> _movieShows; 
        
        public MovieShowRepository()
        {
            DateTime now = DateTime.Now;

            _movieShows = new List<MovieShow>
            {
                new MovieShow()
                {
                    Start = now.Add(TimeSpan.FromHours(1)),
                    End = now.Add(TimeSpan.FromHours(3)),
                    MovieName = "Ben hur"
                },
                new MovieShow()
                {
                    Start = now.Add(TimeSpan.FromHours(3)),
                    End = now.Add(TimeSpan.FromHours(5)),
                    MovieName = "Frozen"
                },
                new MovieShow()
                {
                    Start = now.Add(TimeSpan.FromHours(5)),
                    End = now.Add(TimeSpan.FromHours(7)),
                    MovieName = "Rocky XII"
                }
            };
        }

        public List<MovieShow> GetMovieShows()
        {
            return _movieShows;
        }
    }
}

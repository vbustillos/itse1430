using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary
{
    public class MovieDatabase
    {
        public virtual Movie Add (Movie movie)      //virtual must be added if you want to identify which derived types can be overridden
        {
            _movie = movie;
            return movie;
        }

        public Movie Get (int id)
        {
            if (_movie != null && _movie.Id == id)
                return _movie;

            return null;
        }

        private Movie _movie;
    }
}

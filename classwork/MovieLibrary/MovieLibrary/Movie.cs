namespace MovieLibrary
{
    //Represents a movie
    //If you do not define access modifier on the class default is Internal
    /// <summary>Represents a movie.</summary>
    public class Movie
    {
        //If you do no define access modifier on the members, default is private
        private string _title = "";
        //TODO : Hide this...
        public string _description = "";
        public int _runLength = 0;          //in minutes
        public int _releaseYear = 1900;
        public string _rating = "";
        public bool _isClassic = false;
        
        public bool IsBlackAndWhite()
        {
            return _releaseYear <1939;
        }

        /// <summary>Clones the existing movie.</summary>
        /// <returns>A copy of the movie.</returns>
        public Movie Clone ()                       //function & method are interchangable terms, methods are slower than fields
        {
            var movie = new Movie();
            CopyTo(movie);

            //movie.title = title;
            //movie.description = description;
            //movie.runLength = runLength;
            //movie.releaseYear = releaseYear;
            //movie.rating = rating;
            //movie.isClassic = isClassic;
            return movie;
        }

        /// <summary>Copy the movie to another instance.</summary>
        /// <param name="movie">Movie to copy into.</param>
        public void CopyTo (/*Movie this (represents the instance in which the method was called)*/ Movie movie)

        {
            movie._title = _title;                    //var areEqual = title == this.title
            movie._description = _description;        //system silently translates to this.description
            movie._runLength = _runLength;    
            movie._releaseYear = _releaseYear;
            movie._rating = _rating;
            movie._isClassic = _isClassic;
        }

        public string GetTitle ()
        {
            return _title;
        }

        public void SetTitle(string title)
        {
            //this._title = title;          //'this' is not necessary because underscore is used to name class fields
            _title = title;
        }
    }
}
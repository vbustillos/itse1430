namespace MovieLibrary
{
    //Represents a movie
    //If you do not define access modifier on the class default is Internal
    /// <summary>Represents a movie.</summary>
    public class Movie
    {
        //can specify access modifier in front of get/set, cannot do both and must be more restrictive 
        //known as mixed accessibility
        //(In this case anyone can read, but only Movie class can write)
        public int Id { get; private set; }         

        /// <summary>Gets or sets the title.</summary>
        public string Title             //properties (full property declaration)
        {
            //formal method syntax is string get_Title() - must return a value
            //fix string properties in getter
            get { return String.IsNullOrEmpty(_title) ? "" : _title; }
            //void set_Title (string value) - backing field 
            set { _title = String.IsNullOrEmpty(value) ? "" : value.Trim(); }
        }

        //If you do no define access modifier on the members, default is private
        private string _title;
        //TODO : Hide this...

        public string Description
        {
            get { return String.IsNullOrEmpty(_description) ? "" : _description; }
            set { _description = String.IsNullOrEmpty(value) ? "" : value.Trim(); }
        }
        private string _description;

        /// <summary>Gets or sets the run length in minutes.</summary>
        //public int RunLength                  FULL DECLARATION
        //{
        //    get { return _runLength; }
        //    set { _runLength = value; }
        //}
        //private int _runLength = 0;          //in minutes
        public int RunLength                //AUTO PROPERTY SYNTAX
        {
            get;
            set;
        }

        //public int ReleaseYear
        //{
        //    get { return _releaseYear; }
        //    set { _releaseYear = value;}
        //}
        //private int _releaseYear = 1900;
        public int ReleaseYear { get; set; } = 1900;            //can initialize after using auto property

        public string Rating
        {
            get { return String.IsNullOrEmpty(_rating) ? "" : _rating; }
            set { _rating = String.IsNullOrEmpty(value) ? "" : value.Trim(); }
        }
        private string _rating;

        //public bool IsClassic
        //{
        //    get { return _isClassic; }
        //    set { _isClassic = value; }
        //}
        //private bool _isClassic = false;
        public bool IsClassic { get; set; }
        
        //public bool IsBlackAndWhite()
        //{
        //    return _releaseYear <1939;
        //}

        //calculated property built upon another property, no backing
        public bool IsBlackAndWhite
        {
            get { return ReleaseYear < 1939; }
            //set { }           //getters and setters are optional ---only scenario for set only is passwords
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
            movie.Title = Title;                    //var areEqual = title == this.title
            movie.Description = Description;        //system silently translates to this.description
            movie.RunLength = RunLength;    
            movie.ReleaseYear = ReleaseYear;
            movie.Rating = Rating;
            movie.IsClassic = IsClassic;
        }

        //public string GetTitle ()
        //{
        //    return _title;
        //}

        //public void SetTitle(string title)
        //{
        //    //this._title = title;          //'this' is not necessary because underscore is used to name class fields
        //    _title = title;
        //}
    }
}
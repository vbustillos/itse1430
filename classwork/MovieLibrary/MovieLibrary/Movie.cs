namespace MovieLibrary
{
    //Represents a movie
    //If you do not define access modifier on the class default is Internal
    /// <summary>Represents a movie.</summary>
    public class Movie
    {
        //If you do no define access modifier on the members, default is private
        public string title = "";
        public string description = "";
        public int runLength = 0;          //in minutes
        public int releaseYear = 1900;
        public string rating = "";
        public bool isClassic = false;

    }
}
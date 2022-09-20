//Movie definition
using System;
using MovieLibrary;

Movie movie = new Movie();
movie.title = "Jaws";
movie.releaseYear = 1977;

string title = "";
string description = "";
int runLength = 0;          //in minutes
int releaseYear = 1900;
string rating = "";
bool isClassic = false;

DisplayInformation();
bool done = false;

do
{
    //Type inferencing - compiler figures out type based upon context
    //MenuOption input = DisplayMenu();
    var input = DisplayMenu();                          //to be used when type is unknown and will be determined at compulation
    Console.WriteLine();

    switch(input)
    {
        case MenuOption.Add:
        {
            AddMovie();
            break;
        }
        case MenuOption.Edit:
        {
            EditMovie();
            break;
        }
        case MenuOption.View:
        {
            ViewMovie();
            break;
        }
        case MenuOption.Delete:
        {
            DeleteMovie();
            break;
        }
        case MenuOption.Quit:
        {
            done = true;
            break;
        }
    }
    //if (input == 'A')
    //    AddMovie();
    //else if (input == 'E')
    //    EditMovie();
    //else if (input == 'V')
    //    ViewMovie();
    //else if (input == 'D')
    //    DeleteMovie();
    //else if (input == 'Q')
    //    break;
} while (!done);

//AddMovie();       Remove to call in DisplayMenu function

//Functions
void DisplayInformation()
{
    Console.WriteLine("Movie Library");
    Console.WriteLine("ITSE 1430 Sample");
    Console.WriteLine("Fall 2022");
}
MenuOption DisplayMenu()
{
    Console.WriteLine();
    //Console.WriteLine("---------");
    Console.WriteLine("".PadLeft(10, '-'));
    Console.WriteLine("A)dd Movie");
    Console.WriteLine("E)dit Movie");
    Console.WriteLine("V)iew Movie");
    Console.WriteLine("D)elete Movie");
    Console.WriteLine("Q)uit");
    do
    {
        ConsoleKeyInfo key = Console.ReadKey(true);
        switch (key.Key)
        {
            case ConsoleKey.A: return MenuOption.Add;
            case ConsoleKey.E: return MenuOption.Edit;
            case ConsoleKey.V: return MenuOption.View;
            case ConsoleKey.D: return MenuOption.Delete;
            case ConsoleKey.Q: return MenuOption.Quit;
        };
        //if (key.Key == ConsoleKey.A)
        //    return 'A';
        //else if (key.Key == ConsoleKey.E)
        //    return 'E';
        //else if (key.Key == ConsoleKey.V)
        //    return 'V';
        //else if (key.Key == ConsoleKey.D)
        //    return 'D';
        //else if (key.Key == ConsoleKey.Q)
        //    return 'Q';
    } while (true);
}

bool ReadBoolean (string message)
{
    Console.Write(message);

    //Looking for Y/N
    do
    { 
        ConsoleKeyInfo key= Console.ReadKey();
        if(key.Key == ConsoleKey.Y)
        return true;
        else if (key.Key == ConsoleKey.N)
        return false;
    } while (true);

}

int ReadInt32 ( string message, int minimumValue, int maximumValue )
{
    Console.Write(message);

    do
    { 
        string value = Console.ReadLine();

        //int result;
        //return Int32.Parse(value);
        //if (Int32.TryParse(value, out result))
        //    return result;

        //Inline variable declarations
        if (Int32.TryParse(value, out int result))
        {
            if (result >= minimumValue && result <= maximumValue)
            return result;
        };

        // if (false)
            // break;       //Exit Loop
            // continue;       //Exit Iteration

        Console.WriteLine("Value must be between " + minimumValue + " and " + maximumValue);
    } while (true);

}

string ReadString ( string message, bool required )
{
    Console.Write(message);

    while (true)
    {
        string value = Console.ReadLine();

        //Check if required
        if (value != "" || !required)
            return value;


        //value is empty and required
        Console.WriteLine("Value is required");
    };
}

void AddMovie ()
{
    title = ReadString("Enter a title: ", true);

    description = ReadString("Enter an optional description: ", false);

    runLength = ReadInt32("Enter a run length (in Minutes): ", 0, 300);

    releaseYear = ReadInt32("Enter the release year: ", 1900, 2100);

    rating = ReadString("Enter the MPAA rating: ", true);

    isClassic = ReadBoolean("Is this a classic?");

}

void DeleteMovie ()
{
    //no movie
    if (title =="")
        return;

    //not confirmed
    if (!ReadBoolean("Are you sure you want to delete the movie (Y/N)?"))
        return;

    //TODO: Delete Movie
    title = "";
}

void EditMovie ()
{ }

void ViewMovie ()
{
    if (title =="")
    {
        Console.WriteLine("No movies available");
        return;
    };

    //String Formatting
    //Option 1 - concatenation
    //Console.WriteLine("Length: " + runLength + " mins"); ----> Console.WriteLine(String.Concat("Length: ", runLength, " mins"));

    //Option 2 - String.Format
    //Console.WriteLine("Length: " + runLength + " mins"); ----> Console.WriteLine(String.Format("Length: {0} mins ", runLength));

    //Option 3 - String Interpolation (Only works with string literals)
    //Console.WriteLine(String.Format("Length: {0} mins ", runLength)); ----> Console.WriteLine($"Length: {runLength} mins");
    Console.WriteLine($"{title} ({releaseYear})");
    //Console.WriteLine(releaseYear);             //behind the scenes, the system is reading as Console.WriteLine(releaseYear.ToString());
    //ORIGINAL: Console.WriteLine("Length: " + runLength + " mins");
    Console.WriteLine($"Length: {runLength} mins ");
    Console.WriteLine($"Rated: {rating}");
    Console.WriteLine($"This movie {(isClassic ? "Is" : "Is Not")} considered a classic.");
    Console.WriteLine(description);
}
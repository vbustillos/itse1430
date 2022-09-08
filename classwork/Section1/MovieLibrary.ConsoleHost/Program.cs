//Movie definition
string title = "";
string description = "";
int runLength = 0;          //in minutes
int releaseYear = 1900;
string rating = "";
bool isClassic = false;

AddMovie();

bool ReadBoolean (string message)
{
    Console.Write(message);

    //Looking for Y/N
    ConsoleKeyInfo key= Console.ReadKey();
    if(key.Key == ConsoleKey.Y)
        return true;
    else if (key.Key == ConsoleKey.N)
        return false;

    //TODO: error
    return false;
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
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

int ReadInt32 ( string message )
{
    Console.Write(message);

    string value = Console.ReadLine();

    //int result;
    //return Int32.Parse(value);
    //if (Int32.TryParse(value, out result))
    //    return result;

    //Inline variable declarations
    if (Int32.TryParse(value, out int result))
        return result;

    //TODO: Loop
    return -1;
}

string ReadString ( string message, bool required )
{
    Console.Write(message);

    while (true)
    {
        string value = Console.ReadLine();

        //Check if required
        if (value != "" && !required)
            return value;


        //value is empty and required
        Console.WriteLine("Value is required");
    };
}

void AddMovie ()
{
    title = ReadString("Enter a title: ", true);

    description = ReadString("Enter an optional description: ", false);

    runLength = ReadInt32("Enter a run length (in Minutes): ");

    releaseYear = ReadInt32("Enter the release year: ");

    rating = ReadString("Enter the MPAA rating: ", true);

    isClassic = ReadBoolean("Is this a classic?");

}
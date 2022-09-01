//Movie definition
string title = "";
string description = "";
int runLength = 0;          //in minutes
int releaseYear = 1900;
string rating = "";
bool isClassic = false;

AddMovie();

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

string ReadString ( string message )
{
    Console.Write(message);

    string value = Console.ReadLine();

    return value;
}

void AddMovie ()
{
    title = ReadString("Enter a title: ");

    description = ReadString("Enter an optional description: ");

    runLength = ReadInt32("Enter a run length (in Minutes): ");

    releaseYear = ReadInt32("Enter the release year: ");

    rating = ReadString("Enter the MPAA rating: ");

    Console.WriteLine("Is this a classic? ");
}
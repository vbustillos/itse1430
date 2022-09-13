int hours;

Console.WriteLine("Hours: ");
string value = Console.ReadLine();

hours  = Int32.Parse(value);

Console.WriteLine("Pay Rate: ");
value = Console.ReadLine();

double payRate  = Double.Parse(value);

Console.WriteLine("Your pay is " + (hours * payRate));

int x;
double distanceFromMoon = 0;
//distanceFromMoon = 0;
char letterGrade;
bool isPassing;

string name;
string firstName = "Bob", lastName = "Smith";

//firstName = lastName = name;
//firstName = "Sam";
//lastName = "Sam";

//string lastName;

//int iHours;
//float fRate;



//Block Statement
//{
//    decimal payRate;
//}

//distanceFromMoon = 10.5;
isPassing = distanceFromMoon > 10;

int y = 10;
Console.WriteLine(++y);
Console.WriteLine(y);

Console.WriteLine(--y);
Console.WriteLine(y);

Console.WriteLine(y++);
Console.WriteLine(y);

Console.WriteLine(y--);
Console.WriteLine(y);

//Strings - in C#, everything normalizes to a string

string emptyString = "";            //length of 0 - no characters
string emptyString2 = String.Empty;     //Also of length of 0 - no characters
bool areEmptyStringsEqual = emptyString == emptyString2;
string nullString = null;               //does not have a value - these are bad, will cause problems
bool isEmptyString = (emptyString == null) || (emptyString =="");       //do not use this to check for empty string
isEmptyString = String.IsNullOrEmpty(emptyString);      //way to check to see if a string is null or empty

//String Literals
string someString = "Hello World";          // backslash is used as an escape sequence, translates to actual character \" \n \t \\
string filePath = "C:\\windows\\system32";

//verbatim
filePath = @"C:\windows\system32";

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

//Concatenation
string fullName = "Bob" + " " + "Smith";
fullName = String.Concat("Bob", " ", "Smith");
string someValues = String.Concat("You are ", 10, " Years Old", true);
string names = String.Join(", ", "Bob", "Sue", "Jan", "George");            //used to join with delimiter

int stringLength = fullName.Length;                                         //not a function call
isEmptyString = fullName.Length ==0;                                        //to determine byte length it is length*2

//Manipulation
string upperName = fullName.ToUpper();                                      //To capitalize all characters
string lowerName = fullName.ToLower();                                      //To lower case all characters

fullName = "     Bob Smith       ";
fullName = fullName.Trim();                                                 //to normalize the string - remove leading and trailing white space
fullName = fullName.TrimStart();                                            //to remove space at beginning
fullName = fullName.TrimEnd();                                              //to remove space at end
filePath = filePath.Trim('\\');                                             //to trim specific characters

fullName = fullName.PadLeft(10);                                            //to indent/ set width from left (add comma with character to overload and pad with specific character
fullName = fullName.PadRight(10);                                           //to indent/ set width from right

//Comparison
filePath.StartsWith("C:\\");                                                //returns boolean, used for string parsing
filePath.EndsWith("\\");                                                    //returns boolean, used for string parsing
                                                                            //StartsWith & EndsWith is case sensitive, use StringComparison
filePath.StartsWith("C:\\", StringComparison.OrdinalIgnoreCase);

//Comparison 1 = relational ops (culture aware, case sensitive)
bool areEqual = firstName == lastName;

string input = Console.ReadLine();
//if (input == "A")
if (input.ToUpper() =="A")
    Console.WriteLine("A");
else if (input =="B")
    Console.WriteLine("B");
else
    Console.WriteLine("Other");

//Comparison 2- string.compare, will return >0, ==0, <0, can pass null string
if (String.Compare(input, "A", StringComparison.OrdinalIgnoreCase)==0)
    Console.WriteLine("A");
else if (String.Compare(input, "B", true)==0)                           //adding true will instruct to ignore case
    Console.WriteLine("B");

//comparison 3 - String.Equals
if (String.Equals(input, "A"))
    Console.WriteLine("A");
else if (String.Equals(input,"B", StringComparison.OrdinalIgnoreCase))
    Console.WriteLine("B");


//
//  Valerie Bustillos
//  ITSE 1430 2022 FL
//  Lab 1 09/21/2022
//

using System;

Console.WriteLine("Valerie Bustillos");
Console.WriteLine("ITSE 1430 2022FL");
Console.WriteLine("September 21, 2022");

decimal cartTotal = 0;
DisplayMenu();

int menuChoice;

menuChoice = MenuSelection(0,0);

ProcessMenuSelection(menuChoice);

void DisplayMenu ()
{
    int menuOptionsQuit = 0;

    Console.WriteLine("Your Current Cart Total is: $" + cartTotal);
    Console.WriteLine("Program Menu");
    Console.WriteLine(menuOptionsQuit + " - Quit");
    
}

int MenuSelection (int minimumValue, int maximumValue)
{
    Console.WriteLine("Select an option from the menu:");
    do
    {
        string value = Console.ReadLine();

        if (Int32.TryParse(value, out int result))
        {
            if (result >= minimumValue && result <= maximumValue)
                return result;
        }
        Console.WriteLine("You must selection an option from the menu");
    } while (true);    
}

void ProcessMenuSelection (int menuChoice)
{
    if (menuChoice == 0)
    {
        
        Console.WriteLine("Are you sure you want to quit? (Y/N)");
        ConsoleKeyInfo confirmQuit = Console.ReadKey();
       
        while (confirmQuit.Key != ConsoleKey.Y)
            MenuSelection(0, 0);
        if (confirmQuit.Key == ConsoleKey.Y)
            System.Environment.Exit(0);        
    }

}

//
//  Valerie Bustillos
//  ITSE 1430 2022 FL
//  Lab 1 09/21/2022
//

using System;

DisplayProgramInfo();

do
{
    DisplayCartTotal();
    Console.WriteLine();

    MenuOption input = DisplayMenu();
    switch(input)
    {
        case MenuOption.New:
        {
            BuildNewOrder();
            break;
        }
        case MenuOption.View:
        {
            break;
        }
        case MenuOption.Modify:
        {
            break;
        }
        case MenuOption.Clear:
        {
            break;
        }
        case MenuOption.Quit:
        {
            Quit();
            break;
        }
    }
} while (true);

MenuOption DisplayMenu ()
{
    

    Console.WriteLine("Your Current Cart Total is: $");
    Console.WriteLine("Program Menu");
    Console.WriteLine("N - Start A New Order");
    Console.WriteLine("V - View Order");
    Console.WriteLine("C - Clear Order");
    Console.WriteLine("M - Modify Order");
    Console.WriteLine("Q - Quit");
    
    do
    {
        ConsoleKeyInfo key = Console.ReadKey(true);
        switch (key.Key)
        {
            case ConsoleKey.N: return MenuOption.New;
            case ConsoleKey.V: return MenuOption.View;
            case ConsoleKey.M: return MenuOption.Modify;
            case ConsoleKey.C: return MenuOption.Clear;
            case ConsoleKey.Q: return MenuOption.Quit;
        };
    } while (true);

}

void BuildNewOrder ()
{
    Console.WriteLine("Select your Processor:");
    Console.WriteLine("AMD Ryzen 9 5900X\t$1410".PadRight(40,' '));
    Console.WriteLine("AMD Ryzen 7 5700X\t$1270".PadRight(40,' '));
    Console.WriteLine("AMD Ryzen 5 5600X\t$1200".PadRight(40, ' '));
    Console.WriteLine("Intel i9-12900K\t$1590".PadRight(40, ' '));
    Console.WriteLine("Intel i7-12700K\t$1400".PadRight(40, ' '));
    Console.WriteLine("Intel i5-12600K\t$1280".PadRight(40, ' '));
    CalculateCartTotal();
}

decimal CalculateCartTotal ()
{
    decimal cartTotal = 0;
    decimal processorCost = 0;
    decimal memoryCost = 0;

    cartTotal = processorCost + memoryCost;

    return cartTotal;

}

void Quit()
{
    Console.WriteLine("Are you sure you want to quit the program (Y/N)?");
        

    ConsoleKeyInfo key = Console.ReadKey();
    if (key.Key == ConsoleKey.Y)
        Environment.Exit(0);
    else
        return;
}

void DisplayCartTotal ()
{
    Console.WriteLine(CalculateCartTotal());
}

void DisplayProgramInfo ()
{
    Console.WriteLine("Valerie Bustillos");
    Console.WriteLine("ITSE 1430 2022FL");
    Console.WriteLine("September 21, 2022");
}
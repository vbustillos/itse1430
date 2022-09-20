//
//  Valerie Bustillos
//  ITSE 1430 2022 FL
//  Lab 1 09/21/2022
//

using System;
string processor = "";
double processorPrice = 0;
string memory = "";
double memoryPrice = 0;

DisplayProgramInfo();

do
{
    Console.WriteLine("\nYour Current Cart Total is: $" + DisplayCartTotal(processorPrice, memoryPrice) + "\n");

    MenuOption input = DisplayMenu();
    switch(input)
    {
        case MenuOption.New:
        {
            ProcessorOption processorSelected = SelectProcessor();
            switch(processorSelected)
            {
                case ProcessorOption.AMD1:
                {
                    processor = "AMD Ryzen 9 5900X";
                    processorPrice = 1410;
                    break;
                }
                case ProcessorOption.AMD2:
                {
                    processor = "AMD Ryzen 7 5700X";
                    processorPrice = 1270;
                    break;
                }
                case ProcessorOption.AMD3:
                {
                    processor = "AMD Ryzen 5 5600X";
                    processorPrice = 1200;
                    break;
                }
                case ProcessorOption.Intel1:
                {
                    processor = "Intel i9-12900";
                    processorPrice = 1590;
                    break;
                }
                case ProcessorOption.Intel2:
                {
                    processor = "Intel i7-12700";
                    processorPrice = 1400;
                    break;
                }
                case ProcessorOption.Intel3:
                {
                    processor = "Intel i5-12600";
                    processorPrice = 1280;
                    break;
                }
            }

            MemoryOption memorySelected = SelectMemory();
            switch (memorySelected)
            {
                case MemoryOption.EightGB:
                {
                    memory = "8 GB";
                    memoryPrice = 30;
                    break;
                }
                case MemoryOption.SixteenGB:
                {
                    memory = "16 GB";
                    memoryPrice = 40;
                    break;
                }
                case MemoryOption.ThirtyTwoGB:
                {
                    memory = "32 GB";
                    memoryPrice = 90;
                    break;
                }
                case MemoryOption.SixtyFourGB:
                {
                    memory = "64 GB";
                    memoryPrice = 410;
                    break;
                }
                case MemoryOption.OneTwentyEightGB:
                {
                    memory = "128 GB";
                    memoryPrice = 600;
                    break;
                }
                
            }
            break;
        }
        case MenuOption.View:
        {
            ViewOrder(processor, processorPrice, memory, memoryPrice);
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
    Console.WriteLine("Program Menu");
    Console.WriteLine("N - New Order");
    Console.WriteLine("V - View Order");
    Console.WriteLine("C - Clear Order");
    Console.WriteLine("M - Modify Order");
    Console.WriteLine("Q - Quit\n");
    
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

ProcessorOption SelectProcessor ()
{
    Console.WriteLine("Select your Processor:");
    Console.WriteLine("A - AMD Ryzen 9 5900X\t$1410".PadRight(40,' '));
    Console.WriteLine("B - AMD Ryzen 7 5700X\t$1270".PadRight(40,' '));
    Console.WriteLine("C - AMD Ryzen 5 5600X\t$1200".PadRight(40, ' '));
    Console.WriteLine("D - Intel i9-12900K\t$1590".PadRight(40, ' '));
    Console.WriteLine("E - Intel i7-12700K\t$1400".PadRight(40, ' '));
    Console.WriteLine("F - Intel i5-12600K\t$1280".PadRight(40, ' '));

    do
    {
        ConsoleKeyInfo key = Console.ReadKey(true);
        switch (key.Key)
        {
            case ConsoleKey.A: return ProcessorOption.AMD1;
            case ConsoleKey.B: return ProcessorOption.AMD2;
            case ConsoleKey.C: return ProcessorOption.AMD3;
            case ConsoleKey.D: return ProcessorOption.Intel1;
            case ConsoleKey.E: return ProcessorOption.Intel2;
            case ConsoleKey.F: return ProcessorOption.Intel3;
        };
    } while (true);
}

MemoryOption SelectMemory()
{
    Console.WriteLine("\nSelect your Memory:");
    Console.WriteLine("A - 8 GB\t$30".PadRight(15, ' '));
    Console.WriteLine("B - 16 GB\t$40".PadRight(15, ' '));
    Console.WriteLine("C - 32 GB\t$90".PadRight(15, ' '));
    Console.WriteLine("D - 64 GB\t$410".PadRight(15, ' '));
    Console.WriteLine("E - 128 GB\t$600".PadRight(15, ' '));

    do
    {
        ConsoleKeyInfo key = Console.ReadKey(true);
        switch (key.Key)
        {
            case ConsoleKey.A: return MemoryOption.EightGB;
            case ConsoleKey.B: return MemoryOption.SixteenGB;
            case ConsoleKey.C: return MemoryOption.ThirtyTwoGB;
            case ConsoleKey.D: return MemoryOption.SixtyFourGB;
            case ConsoleKey.E: return MemoryOption.OneTwentyEightGB;
        };
    } while (true);
}


void ViewOrder (string processor, double processorPrice, string memory, double memoryPrice)
{
    if (processor =="")
        Console.WriteLine("You do not have a current order.");
    else
    {
        Console.WriteLine("Your current order includes:");
        Console.WriteLine("Processor:\t" + processor + "\t$" + processorPrice);
        Console.WriteLine("Memory:\t\t" + memory + "\t\t$" + memoryPrice);
    }
}

double DisplayCartTotal (double processorPrice, double memoryPrice)
{
    double cartTotal = processorPrice + memoryPrice;
    return cartTotal;
}

void DisplayProgramInfo ()
{
    Console.WriteLine("Valerie Bustillos");
    Console.WriteLine("ITSE 1430 2022FL");
    Console.WriteLine("September 21, 2022");
}

void Quit ()
{
    Console.WriteLine("Are you sure you want to quit the program (Y/N)?");


    ConsoleKeyInfo key = Console.ReadKey();
    if (key.Key == ConsoleKey.Y)
        Environment.Exit(0);
    else
        return;
}


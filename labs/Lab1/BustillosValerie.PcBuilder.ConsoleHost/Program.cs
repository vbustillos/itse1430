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
string primaryStorage = "";
double primaryStoragePrice = 0;
string secondaryStorage = "";
double secondaryStoragePrice = 0;
string graphicsCard = "";
double graphicsCardPrice = 0;
string operatingSystem = "";
double operatingSystemPrice = 0;

DisplayProgramInfo();

do
{
    Console.WriteLine("\nYour Current Cart Total is: $" + DisplayCartTotal(processorPrice, memoryPrice, primaryStoragePrice, secondaryStoragePrice, graphicsCardPrice, operatingSystemPrice) + "\n");

    MenuOption input = DisplayMenu();
    switch(input)
    {
        case MenuOption.New:
        {
            NewOrder();
            break;
        }
        case MenuOption.View:
        {
            ViewOrder(processor, processorPrice, memory, memoryPrice, primaryStorage, primaryStoragePrice, secondaryStorage, secondaryStoragePrice, graphicsCard, graphicsCardPrice, operatingSystem, operatingSystemPrice);
            break;
        }
        case MenuOption.Modify:
        {
            ModifyOrder();
            break;
        }
        case MenuOption.Clear:
        {
            ClearOrder();
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
    Console.WriteLine("Order Menu");
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

ModifyOrderOption SelectModification()
{
    Console.WriteLine("Which item would you like to modify?");
    Console.WriteLine("P - Processor");
    Console.WriteLine("M - Memory");
    Console.WriteLine("R - Primary Storage");
    Console.WriteLine("S - Secondary Storage");
    Console.WriteLine("G - Graphics Card");
    Console.WriteLine("O - Operating System");
    Console.WriteLine("N - None\n");

    do
    {
        ConsoleKeyInfo key = Console.ReadKey(true);
        switch (key.Key)
        {
            case ConsoleKey.P: return ModifyOrderOption.Processor;
            case ConsoleKey.M: return ModifyOrderOption.Memory;
            case ConsoleKey.R: return ModifyOrderOption.PrimaryStorage;
            case ConsoleKey.S: return ModifyOrderOption.SecondaryStorage;
            case ConsoleKey.G: return ModifyOrderOption.GraphicsCard;
            case ConsoleKey.O: return ModifyOrderOption.OperatingSystem;
            case ConsoleKey:N: return ModifyOrderOption.None;
        };
    } while (true);
}

PrimaryStorageOption SelectPrimaryStorage()
{
    Console.WriteLine("\nSelect your Primary Storage:");
    Console.WriteLine("A - SSD 256 GB\t$90".PadRight(15, ' '));
    Console.WriteLine("B - SSD 512 GB\t$100".PadRight(15, ' '));
    Console.WriteLine("C - SSD 1 TB\t$125".PadRight(15, ' '));
    Console.WriteLine("D - SSD 2 TB\t$230".PadRight(15, ' '));

    do
    {
        ConsoleKeyInfo key = Console.ReadKey(true);
        switch (key.Key)
        {
            case ConsoleKey.A: return PrimaryStorageOption.SSD256GB;
            case ConsoleKey.B: return PrimaryStorageOption.SSD512GB;
            case ConsoleKey.C: return PrimaryStorageOption.SSD1TB;
            case ConsoleKey.D: return PrimaryStorageOption.SSD2TB;
        };
    } while (true);
}

SecondaryStorageOption SelectSecondaryStorage()
{
    Console.WriteLine("\nSelect your Secondary Storage:");
    Console.WriteLine("A - HDD 1 TB\t$40".PadRight(15, ' '));
    Console.WriteLine("B - HDD 2 TB\t$50".PadRight(15, ' '));
    Console.WriteLine("C - HDD 4 TB\t$70".PadRight(15, ' '));
    Console.WriteLine("D - SSD 512 GB\t$100".PadRight(15, ' '));
    Console.WriteLine("E - SSD 1 TB\t$125".PadRight(15, ' '));
    Console.WriteLine("F - SSD 2 TB\t$230".PadRight(15, ' '));
    Console.WriteLine("N - None\t$0".PadRight(15, ' '));

    do
    {
        ConsoleKeyInfo key = Console.ReadKey(true);
        switch (key.Key)
        {
            case ConsoleKey.A: return SecondaryStorageOption.HDD1;
            case ConsoleKey.B: return SecondaryStorageOption.HDD2;
            case ConsoleKey.C: return SecondaryStorageOption.HDD4;
            case ConsoleKey.D: return SecondaryStorageOption.SSD512;
            case ConsoleKey.E: return SecondaryStorageOption.SSD1;
            case ConsoleKey.F: return SecondaryStorageOption.SSD2;
            case ConsoleKey.N: return SecondaryStorageOption.None;
        };
    } while (true);
}

GraphicCardOption SelectGraphicCard()
{
    Console.WriteLine("\nSelect your Graphics Card:");
    Console.WriteLine("A - GeForce RTX 3070\t$580".PadRight(20, ' '));
    Console.WriteLine("B - GeForce RTX 2070\t$400".PadRight(20, ' '));
    Console.WriteLine("C - Radeon RX 6600\t$300".PadRight(20, ' '));
    Console.WriteLine("D - Radeon RX 5600\t$325".PadRight(20, ' '));
    Console.WriteLine("N - None\t\t$0".PadRight(20, ' '));

    do
    {
        ConsoleKeyInfo key = Console.ReadKey(true);
        switch (key.Key)
        {
            case ConsoleKey.A: return GraphicCardOption.GeForceRTX3070;
            case ConsoleKey.B: return GraphicCardOption.GeForceRTX2070;
            case ConsoleKey.C: return GraphicCardOption.RadeonRX6600;
            case ConsoleKey.D: return GraphicCardOption.RadeonRX5600;
            case ConsoleKey.N: return GraphicCardOption.None;
        };
    } while (true);
}

OperatingSystemOption SelectOperatingSystem()
{
    Console.WriteLine("\nSelect your Operating System:");
    Console.WriteLine("A - Windows 11 Home\t$140".PadRight(30, ' '));
    Console.WriteLine("B - Windows 11 Pro\t$160".PadRight(30, ' '));
    Console.WriteLine("C - Windows 10 Home\t$150".PadRight(30, ' '));
    Console.WriteLine("D - Windows 10 Pro\t$170".PadRight(30, ' '));
    Console.WriteLine("E - Linux (Fedora)\t$20".PadRight(30, ' '));
    Console.WriteLine("F - Linux (Red Hat)\t$60".PadRight(30, ' '));

    do
    {
        ConsoleKeyInfo key = Console.ReadKey(true);
        switch (key.Key)
        {
            case ConsoleKey.A: return OperatingSystemOption.Windows11Home;
            case ConsoleKey.B: return OperatingSystemOption.Windows11Pro;
            case ConsoleKey.C: return OperatingSystemOption.Windows10Home;
            case ConsoleKey.D: return OperatingSystemOption.Windows10Pro;
            case ConsoleKey.E: return OperatingSystemOption.LinuxFedora;
            case ConsoleKey.F: return OperatingSystemOption.LinuxRedHat;
        };
    } while (true);
}

bool ReadBoolean (string message)
{
    Console.Write(message);
    do
    {
        ConsoleKeyInfo key = Console.ReadKey(true);
        if (key.Key ==ConsoleKey.Y)
            return true;
        else if (key.Key == ConsoleKey.N)
            return false;
    }while (true);
}

double DisplayCartTotal (double processorPrice, double memoryPrice, double primaryStoragePrice, double secondaryStoragePrice, double graphicsCardPrice, double operatingSystemPrice )
{
    double cartTotal = processorPrice + memoryPrice + primaryStoragePrice + secondaryStoragePrice + graphicsCardPrice + operatingSystemPrice;
    return cartTotal;
}

void ClearOrder()
{

    if (processor == "")
    {
        Console.WriteLine("You do not have a current order saved in your cart.");
        return;
    }
    if (!ReadBoolean("Are you sure you want to clear your cart? (Y/N)\n"))
        return;
    processor = "";
    processorPrice = 0;
    memoryPrice = 0;
    primaryStoragePrice = 0;
    secondaryStoragePrice = 0;
    graphicsCardPrice = 0;
    operatingSystemPrice = 0;
}

void DisplayProgramInfo ()
{
    Console.WriteLine("Valerie Bustillos");
    Console.WriteLine("ITSE 1430 2022FL");
    Console.WriteLine("September 21, 2022");
}

void ModifyOrder()
{
    if (processor == "")
        Console.WriteLine("You do not currently have an order saved in your cart.\n");
    else
    {
        
        do
        {
            ModifyOrderOption component = SelectModification();
            switch (component)
            {
                case ModifyOrderOption.Processor:
                {
                    ProcessorOption processorSelected = SelectProcessor();

                    switch (processorSelected)
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
                    break;
                }
                case ModifyOrderOption.Memory:
                {
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
                case ModifyOrderOption.PrimaryStorage:
                {
                    PrimaryStorageOption primaryStorageSelected = SelectPrimaryStorage();
                    switch (primaryStorageSelected)
                    {
                        case PrimaryStorageOption.SSD256GB:
                        {
                            primaryStorage = "SSD 256 GB";
                            primaryStoragePrice = 90;
                            break;
                        }
                        case PrimaryStorageOption.SSD512GB:
                        {
                            primaryStorage = "SSD 512 GB";
                            primaryStoragePrice = 100;
                            break;
                        }
                        case PrimaryStorageOption.SSD1TB:
                        {
                            primaryStorage = "SSD 1 TB";
                            primaryStoragePrice = 125;
                            break;
                        }
                        case PrimaryStorageOption.SSD2TB:
                        {
                            primaryStorage = "SSD 2 TB";
                            primaryStoragePrice = 230;
                            break;
                        }

                    }
                    break;
                }
                case ModifyOrderOption.SecondaryStorage:
                {
                    SecondaryStorageOption secondaryStorageSelected = SelectSecondaryStorage();
                    switch (secondaryStorageSelected)
                    {
                        case SecondaryStorageOption.HDD1:
                        {
                            secondaryStorage = "HDD 1 TB";
                            secondaryStoragePrice = 40;
                            break;
                        }
                        case SecondaryStorageOption.HDD2:
                        {
                            secondaryStorage = "HDD 2 TB";
                            secondaryStoragePrice = 50;
                            break;
                        }
                        case SecondaryStorageOption.HDD4:
                        {
                            secondaryStorage = "HDD 2 TB";
                            secondaryStoragePrice = 70;
                            break;
                        }
                        case SecondaryStorageOption.SSD512:
                        {
                            secondaryStorage = "SSD 512 GB";
                            secondaryStoragePrice = 100;
                            break;
                        }
                        case SecondaryStorageOption.SSD1:
                        {
                            secondaryStorage = "SSD 1 TB";
                            secondaryStoragePrice = 125;
                            break;
                        }
                        case SecondaryStorageOption.SSD2:
                        {
                            secondaryStorage = "SSD 2 TB";
                            secondaryStoragePrice = 230;
                            break;
                        }
                        case SecondaryStorageOption.None:
                        {
                            secondaryStorage = "None Selected";
                            secondaryStoragePrice = 0;
                            break;
                        }
                    }
                    break;
                }
                case ModifyOrderOption.GraphicsCard:
                {
                    GraphicCardOption graphicCardSelected = SelectGraphicCard();
                    switch (graphicCardSelected)
                    {
                        case GraphicCardOption.GeForceRTX3070:
                        {
                            graphicsCard = "GeForce RTX 3070";
                            graphicsCardPrice = 580;
                            break;
                        }
                        case GraphicCardOption.GeForceRTX2070:
                        {
                            graphicsCard = "GeForce RTX 2070";
                            graphicsCardPrice = 400;
                            break;
                        }
                        case GraphicCardOption.RadeonRX6600:
                        {
                            graphicsCard = "Radeon RX 6600";
                            graphicsCardPrice = 300;
                            break;
                        }
                        case GraphicCardOption.RadeonRX5600:
                        {
                            graphicsCard = "Radeon RX 5600";
                            graphicsCardPrice = 325;
                            break;
                        }
                        case GraphicCardOption.None:
                        {
                            graphicsCard = "None Selected";
                            graphicsCardPrice = 0;
                            break;
                        }
                    }
                    break;
                }
                case ModifyOrderOption.OperatingSystem:
                {
                    OperatingSystemOption operatingSystemSelected = SelectOperatingSystem();
                    switch (operatingSystemSelected)
                    {
                        case OperatingSystemOption.Windows11Home:
                        {
                            operatingSystem = "Windows 11 Home";
                            operatingSystemPrice = 140;
                            break;
                        }
                        case OperatingSystemOption.Windows11Pro:
                        {
                            operatingSystem = "Windows 11 Pro";
                            operatingSystemPrice = 160;
                            break;
                        }
                        case OperatingSystemOption.Windows10Home:
                        {
                            operatingSystem = "Windows 10 Home";
                            operatingSystemPrice = 150;
                            break;
                        }
                        case OperatingSystemOption.Windows10Pro:
                        {
                            operatingSystem = "Windows 10 Pro";
                            operatingSystemPrice = 170;
                            break;
                        }
                        case OperatingSystemOption.LinuxFedora:
                        {
                            operatingSystem = "Linux (Fedora)";
                            operatingSystemPrice = 20;
                            break;
                        }
                        case OperatingSystemOption.LinuxRedHat:
                        {
                            operatingSystem = "Linux (Red Hat)";
                            operatingSystemPrice = 60;
                            break;
                        }
                    }
                    break;
                }
                case ModifyOrderOption.None:
                {
                    break;                    
                }
            }
            
        } while (ReadBoolean("Would you like to modify another item in your cart (Y/N)\n\n"));

    }
}

void NewOrder ()
{
    ProcessorOption processorSelected = SelectProcessor();
    switch (processorSelected)
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

    PrimaryStorageOption primaryStorageSelected = SelectPrimaryStorage();
    switch (primaryStorageSelected)
    {
        case PrimaryStorageOption.SSD256GB:
        {
            primaryStorage = "SSD 256 GB";
            primaryStoragePrice = 90;
            break;
        }
        case PrimaryStorageOption.SSD512GB:
        {
            primaryStorage = "SSD 512 GB";
            primaryStoragePrice = 100;
            break;
        }
        case PrimaryStorageOption.SSD1TB:
        {
            primaryStorage = "SSD 1 TB";
            primaryStoragePrice = 125;
            break;
        }
        case PrimaryStorageOption.SSD2TB:
        {
            primaryStorage = "SSD 2 TB";
            primaryStoragePrice = 230;
            break;
        }

    }

    SecondaryStorageOption secondaryStorageSelected = SelectSecondaryStorage();
    switch (secondaryStorageSelected)
    {
        case SecondaryStorageOption.HDD1:
        {
            secondaryStorage = "HDD 1 TB";
            secondaryStoragePrice = 40;
            break;
        }
        case SecondaryStorageOption.HDD2:
        {
            secondaryStorage = "HDD 2 TB";
            secondaryStoragePrice = 50;
            break;
        }
        case SecondaryStorageOption.HDD4:
        {
            secondaryStorage = "HDD 2 TB";
            secondaryStoragePrice = 70;
            break;
        }
        case SecondaryStorageOption.SSD512:
        {
            secondaryStorage = "SSD 512 GB";
            secondaryStoragePrice = 100;
            break;
        }
        case SecondaryStorageOption.SSD1:
        {
            secondaryStorage = "SSD 1 TB";
            secondaryStoragePrice = 125;
            break;
        }
        case SecondaryStorageOption.SSD2:
        {
            secondaryStorage = "SSD 2 TB";
            secondaryStoragePrice = 230;
            break;
        }
        case SecondaryStorageOption.None:
        {
            secondaryStorage = "None Selected";
            secondaryStoragePrice = 0;
            break;
        }
    }

    GraphicCardOption graphicCardSelected = SelectGraphicCard();
    switch (graphicCardSelected)
    {
        case GraphicCardOption.GeForceRTX3070:
        {
            graphicsCard = "GeForce RTX 3070";
            graphicsCardPrice = 580;
            break;
        }
        case GraphicCardOption.GeForceRTX2070:
        {
            graphicsCard = "GeForce RTX 2070";
            graphicsCardPrice = 400;
            break;
        }
        case GraphicCardOption.RadeonRX6600:
        {
            graphicsCard = "Radeon RX 6600";
            graphicsCardPrice = 300;
            break;
        }
        case GraphicCardOption.RadeonRX5600:
        {
            graphicsCard = "Radeon RX 5600";
            graphicsCardPrice = 325;
            break;
        }
        case GraphicCardOption.None:
        {
            graphicsCard = "None Selected";
            graphicsCardPrice = 0;
            break;
        }

    }

    OperatingSystemOption operatingSystemSelected = SelectOperatingSystem();
    switch (operatingSystemSelected)
    {
        case OperatingSystemOption.Windows11Home:
        {
            operatingSystem = "Windows 11 Home";
            operatingSystemPrice = 140;
            break;
        }
        case OperatingSystemOption.Windows11Pro:
        {
            operatingSystem = "Windows 11 Pro";
            operatingSystemPrice = 160;
            break;
        }
        case OperatingSystemOption.Windows10Home:
        {
            operatingSystem = "Windows 10 Home";
            operatingSystemPrice = 150;
            break;
        }
        case OperatingSystemOption.Windows10Pro:
        {
            operatingSystem = "Windows 10 Pro";
            operatingSystemPrice = 170;
            break;
        }
        case OperatingSystemOption.LinuxFedora:
        {
            operatingSystem = "Linux (Fedora)";
            operatingSystemPrice = 20;
            break;
        }
        case OperatingSystemOption.LinuxRedHat:
        {
            operatingSystem = "Linux (Red Hat)";
            operatingSystemPrice = 60;
            break;
        }

    }
    
}

void Quit ()
{
    if (ReadBoolean("Are you sure you want to quit (Y/N)?\n"))
        Environment.Exit(0);
    else
        return;
}

void ViewOrder (string processor, double processorPrice, string memory, double memoryPrice, string primaryStorage, double primaryStoragePrice, string secondaryStorage, double secondaryStoragePrice, string graphicsCard, double graphicsCardPrice, string operatingSystem, double operatingSystemPrice )
{
    if (processor =="")
        Console.WriteLine("You do not have a current order saved in your cart.");
    else
    {
        Console.WriteLine("Your current order includes:");
        Console.WriteLine($"Processor:\t\t{processor}  \t\t${processorPrice}");
        Console.WriteLine($"Memory:\t\t\t{memory}\t\t\t\t${memoryPrice}");
        Console.WriteLine($"Primary Storage:\t{primaryStorage}\t\t\t${primaryStoragePrice}");
        Console.WriteLine($"Secondary Storage:\t{secondaryStorage}\t\t\t${secondaryStoragePrice}");
        Console.WriteLine($"Graphics Card:\t\t{graphicsCard}      \t\t${graphicsCardPrice}");
        Console.WriteLine($"Operating System:\t{operatingSystem}\t\t\t${operatingSystemPrice}");
        Console.WriteLine("".PadLeft(80, '-'));
        Console.WriteLine($"Total: ${DisplayCartTotal(processorPrice, memoryPrice, primaryStoragePrice, secondaryStoragePrice, graphicsCardPrice, operatingSystemPrice)}".PadLeft(61, ' '));
    }
}

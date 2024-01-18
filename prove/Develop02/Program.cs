using System;
using System.Collections.Generic;

class Program
{
    public int MenuPrompt()
    {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do?:  ");
        string sNumber = Console.ReadLine();
        int number = int.Parse(sNumber);
        return number;
    }

    static void Main(string[] args)
    {
        Journal j = new Journal();

        while (true) {
            Program myProgram = new Program();
            int number = myProgram.MenuPrompt();
            Entry e = new Entry();

            if (number == 1) 
            {
                e.Display();
                j.AddEntry(e);
            }

            else if (number == 2) 
            {
                j.DisplayAll();
            }

            else if (number == 3) 
            {
                Console.WriteLine("What is the filename?");
                string file = Console.ReadLine();
                j.LoadFromFile(file);
            }

            else if (number == 4) 
            {
                Console.WriteLine("What is the filename?");
                string file = Console.ReadLine();
                j.SaveToFile(file);
            }

            else if (number == 5) 
            {
                break;
            }
        }
    }
}
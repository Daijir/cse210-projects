using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            //clear console
            Console.Clear();
            
            //show Menu
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            string sInput = Console.ReadLine();
            int input = int.Parse(sInput);

            if (input == 1)
            {
                //start breathing activity
                BreathingActivity breathing = new BreathingActivity("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.\n");
                breathing.DisplayStartingMessage();
                breathing.Run();
                breathing.DisplayEndingMessage();
            }

            else if (input == 2)
            {
                //Exceeding Requirements: no random prompts/questions are selected until they have all been used at least once in that session.
                //start reflecting activity
                ReflectingActivity reflecting = new ReflectingActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recongnize the power you have and how you can use it in other aspects of your life.\n");
                reflecting.DisplayStartingMessage();
                reflecting.Run();
                reflecting.DisplayEndingMessage();

            }

            else if (input == 3)
            {
                //start listing activity
                ListingActivity listing = new ListingActivity("Listing", "This activity will help you reflect on the good things your life by having you list as many things as you can in a certain area.\n");
                listing.DisplayStartingMessage();
                listing.Run();
                listing.DisplayEndingMessage();
            }

            else if (input == 4)
            {
                //quit
                break;
            }
        }
    }
}
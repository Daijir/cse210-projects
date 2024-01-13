using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int m = random.Next(1, 100);
        int count = 0;

        while (true) 
        {
            Console.Write("What is your guess?  ");
            string gString = Console.ReadLine();
            int g = int.Parse(gString);
            count += 1;
            
            if (m < g) 
            {
                Console.WriteLine("Higher");
            }

            else if (m > g)
            {
                Console.WriteLine("Lower");
            }

            else if (m == g)
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"number of attempts:  {count}");
                Console.Write("Do you want to play again? (yes/no):  ");
                string answer = Console.ReadLine();
                if (answer == "yes")
                {
                    m = random.Next(1, 100);
                    count = 0;
                }
                else if (answer == "no")
                {
                    break;
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //variables that are used in loop
        int j = 0;
        int n = 3;

        //scripture text
        string text = "Trust in the Lord with all thine heart and lean not on thine own understanding; in all your ways acknowledge him, and he shall direct thy paths.\n";

        //create instances
        Reference r = new Reference("Proverbs", 3, 5, 6);
        Scripture s = new Scripture(r,text);

        //create a list of words of text to get the length of array
        string[] textArray = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int length = textArray.Length;

        //create a list of numbers in random order
        List<int> numberList = Enumerable.Range(0, length).ToList();
        List<int> randomNumbers = GenerateRandomNumbers(numberList);

        while (true)
        {
            //clear console
            Console.Clear();

            //show reference and scripture
            string scriptureText = s.GetDisplayText();
            Console.WriteLine(scriptureText);

            //it break this loop if text is completely hidden
            if (s.IsCompletelyHidden())
            {
                break;
            }

            //show prompt and get input
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            Console.WriteLine("(you can also type 'show' to restore words were hided last time)");
            string input = Console.ReadLine();

            // discriminant expression of ENTER key => hide three random words
            if (string.IsNullOrWhiteSpace(input))
            {
                //iterate three times
                for (int i = j; i < n; i++)
                {
                    if (i > length - 1)
                    {
                        break;
                    }
                    s.HideRandomWords(randomNumbers[i]);
                }
                j += 3;
                n += 3;
            }

            // this is the additional feature
            // discriminant expression of 'show' => restore three words that were hidden last time
            else if (input == "show")
            {
                j -= 3;
                n -= 3;
                //iterate three times
                for (int i = j; i < n; i++)
                {
                    if (i > length - 1)
                    {
                        break;
                    }
                    s.ShowRandomWords(randomNumbers[i]);
                }
            }

            // discriminant expression of 'quit' => end program
            else if (input == "quit")
            {
                break;
            }
        }
    }

    // a method which makes a list of numbers ordered randomely
    static List<int> GenerateRandomNumbers(List<int> list)
    {
        Random random = new Random();
        //Randomize the order of the list
        List<int> randomNumbers = list.OrderBy(x => random.Next()).ToList();
        return randomNumbers;
    }
}
using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    private int j = 0;
    private List<int> _numberList;
    private List<int> _randomNumbers;

    public ReflectingActivity(string name, string description)
        : base(name, description)
    {
        //Add prompts to the list
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did somethin really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truely selfless.");

        //Add questions to the list
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");

        //Random numbers for avoiding duplication
        _numberList = Enumerable.Range(0, _questions.Count).ToList();
        _randomNumbers = GenerateRandomNumbers(_numberList);
    }

    public void Run()
    {
        //clear console 
        Console.Clear();

        //show first prompt
        Console.WriteLine("Get Ready... ");
        base.ShowSpinner(5);
        Console.WriteLine("\nConsider the following prompt:");
        DisplayPropmt();

        //detect pressing enter 
        Console.WriteLine($"\nWhen you have something in mind, press enter to continue.");
        string input = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
            Console.Write("You may begin in: ");
            base.ShowCountDown(5);

            //iterate activity according to duration time
            for (int i = 0; i < _duration; i += 10)
            {
                DisplayQuestion();
            }
        }

    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int r = random.Next(0, _prompts.Count);
        return _prompts[r];
    }

    public string GetRandomQuestion()
    {
        if (j > 8) 
        {
            j = 0;
        }
        string output = _questions[_randomNumbers[j]];
        return output;
    }

    public void DisplayPropmt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($"--- {prompt} ---");
    }

    public void DisplayQuestion()
    {
        string question = GetRandomQuestion();
        Console.Write($"\n> {question} {_randomNumbers[j]} {j}");
        j ++;
        base.ShowSpinner(10);
    }

    //Exceeding Requirements: 
    // a method which makes a list of numbers ordered randomely
    static List<int> GenerateRandomNumbers(List<int> list)
    {
        Random random = new Random();
        //Randomize the order of the list
        List<int> randomNumbers = list.OrderBy(x => random.Next()).ToList();
        return randomNumbers;
    }
}
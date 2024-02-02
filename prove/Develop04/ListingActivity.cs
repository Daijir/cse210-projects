using System;
using System.Diagnostics;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();
    private List<string> _userList = new List<string>();

    public ListingActivity(string name, string description)
        : base(name, description)
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public void Run()
    {
         //clear console 
        Console.Clear();

        //show first prompt
        Console.WriteLine("Get Ready...");
        base.ShowSpinner(5);
        Console.WriteLine("List as many responses you can to following prompt:");
        GetRandomPrompt();
        Console.Write("You may begin in: \n");
        base.ShowCountDown(5);

        //get count and show result
        _userList = GetListFromUser();
        _count = _userList.Count;
        Console.WriteLine($"You listed {_count} items!");
        
    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int r = random.Next(0, _prompts.Count);
        string prompt = _prompts[r];
        Console.WriteLine($"--- {prompt} ---");
    }

    public List<string> GetListFromUser()
    {
        Stopwatch stopwatch = Stopwatch.StartNew();
        List<string> list = new List<string>();
        while (true)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            list.Add(input);
            if (stopwatch.ElapsedMilliseconds >= _duration * 1000) 
            {
                break;
            }

        }

        return list;
    }
}
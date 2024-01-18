using System;
using System.Collections.Generic;

public class PromptGenerator
{
    // make new string list
    public List<string> _prompts = new List<string>();

    public PromptGenerator()
    {
        // add five prompts to the list
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
    }

    public string GetRandomPrompt()
    {
        // generate random number between 0 to 4
        Random r = new Random();
        int n = r.Next(0,5);

        return _prompts[n];
    }
}
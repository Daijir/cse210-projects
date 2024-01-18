public class Entry
{
    private PromptGenerator p = new PromptGenerator();
    private DateTime theCurrentTime = DateTime.Now;
    public string _date;
    public string _promptText;
    public string _entryText;


    public Entry()
    {
        _date = "Date: " + theCurrentTime.ToShortDateString();
        _promptText = "Prompt: " + p.GetRandomPrompt();
    }

    public void Display()
    {
        Console.WriteLine(_promptText);
        Console.Write("> ");
        _entryText = Console.ReadLine();
    }

}
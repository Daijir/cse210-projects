public class BreathingActivity : Activity
{

    public BreathingActivity(string name, string description)
        : base(name, description)
    {
    }

    public void Run()
    {
        //clear console
        Console.Clear();

        //show first prompt
        Console.WriteLine("Get Ready... ");
        base.ShowSpinner(5);
        Console.Write("Breathe in... ");
        base.ShowCountDown(2);
        Console.Write("\nNow breathe out... ");
        base.ShowCountDown(3);

        //iterate activity according to duration time
        for (int i = 0; i < _duration; i += 10)
        {
            Console.Write("\n\nBreathe in... ");
            base.ShowCountDown(4);
            Console.Write("\nNow breathe out... ");
            base.ShowCountDown(6);
        }
    }
}
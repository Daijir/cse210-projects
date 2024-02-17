using System;

class Program
{
    static void Main(string[] args)
    {
         List<Activity> activities = new List<Activity>
        {
            new Running("03 Nov 2022", 30, 3.0),
            new Running("03 Nov 2022", 30, 4.8),
            new Bicycle("03 Nov 2022", 30, 12),
            new Swimming("03 Nov 2022", 30, 20)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
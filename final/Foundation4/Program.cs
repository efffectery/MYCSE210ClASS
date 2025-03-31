using System;

class Program
{
    static void Main(string[] args)
    {
        Running run = new Running("2003 Nov 06", 30, 8.23F);
        Cycling cycle = new Cycling("1987 March 01", 45, 11F);
        Swimming swim = new Swimming("1996 June 22", 100, 8);

        List<Activity> activities = new List<Activity> {run, cycle, swim};

        foreach(Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
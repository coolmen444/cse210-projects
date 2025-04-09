using System;

class Program
{
    static void Main(string[] args)
    {
        

        List<Activity> activityList = new List<Activity>()
        {
            new RunningActivity("03 Nov 2022", 30, 4.8),
            new CyclingActivity("04 Dec 2024", 25, 21),
            new SwimmingActivity("08 Oct 2025", 10, 10)
        };

        foreach (Activity act in activityList)
        {
            Console.WriteLine(act.GetSummary());
        }
  
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        RunningActivity running = new RunningActivity(55, 5);
        CyclingActivity cycling = new CyclingActivity(124, 16);
        SwimmingActivity swimming = new SwimmingActivity(136, 50);
        List<Activity> activities = new List<Activity>();
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        foreach (Activity a in activities)
        {
            Console.WriteLine(a.GetSummary());
        }
    }
}
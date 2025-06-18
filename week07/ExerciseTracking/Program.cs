using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        RunningActivity running = new RunningActivity(30, 4.8);
        CyclingActivity cycling = new CyclingActivity(50,7.6);
        SwimmingActivity swimming = new SwimmingActivity(64, 205);
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
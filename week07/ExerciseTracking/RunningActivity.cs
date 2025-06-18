using System;

public class RunningActivity : Activity
{
    public RunningActivity(double time, double distance) : base(time, distance)
    {
        _activity = "Running";
    }

    
}
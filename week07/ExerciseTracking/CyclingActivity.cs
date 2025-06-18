using System;

public class CyclingActivity : Activity
{
    int _laps;
    public CyclingActivity(double time, double distance) : base(time, distance)
    {
        _activity = "Cycling";
    }

    
}
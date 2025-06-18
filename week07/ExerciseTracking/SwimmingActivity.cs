using System;

public class SwimmingActivity : Activity
{
    int _laps;
    public SwimmingActivity(double time, double distance) : base(time, distance)
    {
        _laps = 0;
        _activity = "Swimming";
    }
    public override string GetSummary()
    {
        return $"{base.GetSummary()}, n of laps: {GetDistance()*1000/50}";
    }
}
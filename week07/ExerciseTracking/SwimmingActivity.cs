using System;

public class SwimmingActivity : Activity
{
    private int _laps;
    public SwimmingActivity(double length, int laps) : base(length)
    {
        _laps = laps;
        _activity = "Swimming";
    }
    public override double GetDistance()
    {
        return _laps * 50 / 1000;
    }
    public override double GetSpeed()
    {
        return GetDistance() / GetLength() * 60;
    }
    public override double GetPace()
    {
        return GetLength() / GetDistance();
    }
    
    public override string GetSummary()
    {
        return $"{base.GetSummary()}, Distance {GetDistance().ToString("F2")} km Speed: {GetSpeed().ToString("F2")} kph, Pace: {GetPace()} min/km,  N of laps: {_laps}";
    }
}
using System;
using System.Net.Http.Headers;

public class RunningActivity : Activity
{
    private double _distance;
    public RunningActivity(double length, double distance) : base(length)
    {
        _activity = "Running";
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return _distance / GetLength() * 60;
    }
    public override double GetPace()
    {
        return GetLength() / _distance;
    }
    public override string GetSummary()
    {
        return $"{base.GetSummary()} -Distance {_distance} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min/km";
    }
}
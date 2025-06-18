using System;

public class CyclingActivity : Activity
{
    private double _speed;
    public CyclingActivity(double length, double speed) : base(length)
    {
        _activity = "Cycling";
        _speed = speed;
    }
    public override double GetDistance()
    {
        return _speed * GetLength() / 60;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return GetLength() / GetDistance();
    }
    public override string GetSummary()
    {
        return $"{base.GetSummary()} -Distance {GetDistance().ToString("F2")} km, Speed: {_speed} kph, Pace: {GetPace().ToString("F2")}min/km";
    }

    
}
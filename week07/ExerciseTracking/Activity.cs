using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;

public class Activity
{
    protected double _time;
    protected double _distance;
    protected string _date;
    protected string _activity;
    public Activity(double time, double distance)
    {
        _time = time;
        _distance = distance;
        _activity = "";

    }
    public double GetTime()
    {
        return _time;
    }
    
    public string GetDate()
    {
        DateTime date = DateTime.Now;
        _date=date.ToString("dd MMM yyyy");
        return _date;
    }
    public double GetDistance()
    {
        return _distance;
    }
    public string GetActivity()
    {
        return _activity;
    }
    
    public virtual string GetSummary()
    {
        return $"{GetDate()} {GetActivity()} ({GetTime()} min). Distance {GetDistance()}km, Speed {(GetDistance() / GetTime() * 60).ToString("F2")} kph, Pace: {GetTime() / GetDistance()} min per km";
    }



}

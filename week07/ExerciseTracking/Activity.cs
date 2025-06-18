using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;

public abstract class Activity
{
    protected double _length;
    protected string _date;
    protected string _activity;
    public Activity(double length)
    {
        _length = length;
        _activity = "";
    }
    public double GetLength()
    {
        return _length;
    }
    public abstract Double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    
    
    public string GetDate()
    {
        DateTime date = DateTime.Now;
        _date = date.ToString("dd MMM yyyy");
        return _date;
    }
    public string GetActivity()
    {
        return _activity;
    }
    
    public virtual string GetSummary()
    {
        return $"{GetDate()} {GetActivity()} ({GetLength()}min)";
    }



}

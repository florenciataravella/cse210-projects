using System;
using System.IO.Pipes;

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description =description;
        _points = points;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public string GetName()
    {
    
        return _name;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public string GetDescription()
    {
       
        return _description;
    }
    public void SetPoints(int points)
    {
        _points = points;
    }
    public int GetPoints()
    {
        return _points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        if (IsComplete() == false)
        {
            return $"[] {GetName()} ({GetDescription()})";
        }
        else
        {
            return $"[X] {GetName()} ({GetDescription()})";
        }
    }

    public abstract string GetStringRepresentation();
    
}
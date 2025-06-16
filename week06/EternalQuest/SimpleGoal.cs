using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }
    
    public override string GetStringRepresentation()
    {
        
        return $"SimpleGoal: {GetName()},{GetDescription()},{GetPoints()},{IsComplete()}";
    }
    public override bool IsComplete()
    {
        if (_isComplete == false)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    public override void RecordEvent()
    {
        _isComplete = true;
        
    }
}
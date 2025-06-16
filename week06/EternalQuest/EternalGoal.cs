using System;
using System.ComponentModel;

public class EternalGoal : Goal
{

    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal: {GetName()},{GetDescription()},{GetPoints()}";
    }
   
    public override bool IsComplete()
    {
        return false;
    }
    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations, you earned {GetPoints()} points!");
        
    }
}
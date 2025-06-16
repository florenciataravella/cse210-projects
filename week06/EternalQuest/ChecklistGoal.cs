using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;

    }
    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }
    public int GetTarget()
    {
        return _target;
    }
    public int GetBonus()
    {
        return _bonus;
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal: {GetName()},{GetDescription()},{GetPoints()},{GetBonus()},{GetTarget()},{GetAmountCompleted()}";
    }
    public override string GetDetailsString()
    {
        if (_amountCompleted < _target)
        {
            return $"[] {GetName()} ({GetDescription()})-- Currently completed: {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[X] {GetName()} ({GetDescription()})-- Currently completed: {_amountCompleted}/{_target}";
        }
    }
    public override void RecordEvent()
    {
        _amountCompleted = _amountCompleted + 1;

        if (_amountCompleted == _target)
        {

            Console.WriteLine($"Congratulations! You earned {GetPoints() + GetBonus()} points.");
        }
        else
        {
            Console.WriteLine($"You earned {GetPoints()} points.");

        }
    }
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
}
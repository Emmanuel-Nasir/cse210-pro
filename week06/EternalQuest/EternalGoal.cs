using System;

class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) { }

    public override void RecordEvent()
    {
        Console.WriteLine($"{Name} recorded! You earned {Points} points.");
    }

    public override string GetDetailsString()
    {
        return $"{Name} (Eternal Goal)";
    }
}

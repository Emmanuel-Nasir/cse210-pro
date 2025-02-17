using System;

class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name, points) { }

    public override void RecordEvent()
    {
        IsCompleted = true;
        Console.WriteLine($"{Name} completed! You earned {Points} points.");
    }

    public override string GetDetailsString()
    {
        return $"{(IsCompleted ? "[X]" : "[ ]")} {Name}";
    }
}

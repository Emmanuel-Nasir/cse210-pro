using System;

class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public int TargetCount { get => _targetCount; set => _targetCount = value; }
    public int CurrentCount { get => _currentCount; set => _currentCount = value; }
    public int BonusPoints { get => _bonusPoints; set => _bonusPoints = value; }

    public ChecklistGoal(string name, int points, int targetCount, int bonusPoints) : base(name, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _bonusPoints = bonusPoints;
    }

    public override void RecordEvent()
    {
        _currentCount++;
        Console.WriteLine($"{Name} recorded! You earned {Points} points.");
        if (_currentCount >= _targetCount)
        {
            IsCompleted = true;
            Console.WriteLine($"Congratulations! You completed {Name} and earned an additional {BonusPoints} points.");
        }
    }

    public override string GetDetailsString()
    {
        return $"{(IsCompleted ? "[X]" : "[ ]")} {Name} - Completed {CurrentCount}/{TargetCount} times";
    }
}

public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name, points) {}
    
    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
        }
    }

    public override string GetStatus()
    {
        return _isComplete ? "[X] " + _name : "[ ] " + _name;
    }

    public override string SaveData()
    {
        return $"SimpleGoal,{_name},{_points},{_isComplete}";
    }
}
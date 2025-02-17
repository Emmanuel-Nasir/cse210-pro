public class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) {}
    
    public override void RecordEvent()
    {
        // No completion, always ongoing
    }

    public override string GetStatus()
    {
        return "[∞] " + _name;
    }

    public override string SaveData()
    {
        return $"EternalGoal,{_name},{_points}";
    }
}
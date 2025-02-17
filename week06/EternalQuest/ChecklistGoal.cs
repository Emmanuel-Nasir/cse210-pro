public class ChecklistGoal : Goal
{
    private int _target;
    private int _current;
    private int _bonus;

    public ChecklistGoal(string name, int points, int target, int bonus) : base(name, points)
    {
        _target = target;
        _current = 0;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        if (_current < _target)
        {
            _current++;
            if (_current == _target)
            {
                _isComplete = true;
            }
        }
    }

    public override string GetStatus()
    {
        string progressBar = new string('█', _current) + new string('-', _target - _current);
        return _isComplete ? $"[X] {_name} (Completed)" : $"[ ] {_name} [{progressBar}] ({_current}/{_target})";
    }

    public override string SaveData()
    {
        return $"ChecklistGoal,{_name},{_points},{_current},{_target},{_bonus}";
    }

    public int GetCurrent() => _current;
    public int GetTarget() => _target;
    public int GetBonus() => _bonus;
}
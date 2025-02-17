public abstract class Goal
{
    protected string _name;
    protected int _points;
    protected bool _isComplete;

    public Goal(string name, int points)
    {
        _name = name;
        _points = points;
        _isComplete = false;
    }

    public abstract void RecordEvent();
    public abstract string GetStatus();
    public abstract string SaveData();
    
    public string GetName() => _name;
    public int GetPoints() => _points;
    public bool IsComplete() => _isComplete;
}
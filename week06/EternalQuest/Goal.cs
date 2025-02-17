using System;

abstract class Goal
{
    private string _name;
    private int _points;
    private bool _isCompleted;

    public string Name { get => _name; set => _name = value; }
    public int Points { get => _points; set => _points = value; }
    public bool IsCompleted { get => _isCompleted; set => _isCompleted = value; }

    public abstract void RecordEvent();
    public abstract string GetDetailsString();

    public Goal(string name, int points)
    {
        _name = name;
        _points = points;
        _isCompleted = false;
    }
}
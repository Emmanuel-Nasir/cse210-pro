public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    private int _highScore;

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(string goalName)
    {
        foreach (var goal in _goals)
        {
            if (goal.GetName() == goalName)
            {
                goal.RecordEvent();
                _score += goal.GetPoints();
                if (goal is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
                {
                    _score += checklistGoal.GetBonus();
                }
                break;
            }
        }
        if (_score > _highScore)
        {
            _highScore = _score;
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("\nYour Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()}");
        }
        Console.WriteLine($"Total Score: {_score}");
        Console.WriteLine($"High Score: {_highScore}");
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            writer.WriteLine(_highScore);
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.SaveData());
            }
        }
    }

    public void LoadGoals(string filename)
    {
        if (File.Exists(filename))
        {
            _goals.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                _score = int.Parse(reader.ReadLine());
                _highScore = int.Parse(reader.ReadLine());
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts[0] == "SimpleGoal")
                        _goals.Add(new SimpleGoal(parts[1], int.Parse(parts[2])));
                    else if (parts[0] == "EternalGoal")
                        _goals.Add(new EternalGoal(parts[1], int.Parse(parts[2])));
                    else if (parts[0] == "ChecklistGoal")
                        _goals.Add(new ChecklistGoal(parts[1], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4])));
                }
            }
        }
    }
}

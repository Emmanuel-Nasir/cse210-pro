using System;
using System.Collections.Generic;
using System.IO;

class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private int _level;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
        _level = 1; // Initialize level
    }

    public void CreateNewGoal()
    {
        Console.WriteLine("Enter goal name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter goal type (simple, eternal, checklist): ");
        string type = Console.ReadLine();
        Console.WriteLine("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        switch (type.ToLower())
        {
            case "simple":
                _goals.Add(new SimpleGoal(name, points));
                break;
            case "eternal":
                _goals.Add(new EternalGoal(name, points));
                break;
            case "checklist":
                Console.WriteLine("Enter target count: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter bonus points: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, points, targetCount, bonusPoints));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("Enter goal name to record event: ");
        string name = Console.ReadLine();
        Goal goal = _goals.Find(g => g.Name == name);
        if (goal != null)
        {
            goal.RecordEvent();
            _score += goal.Points;
            if (goal is ChecklistGoal checklistGoal && checklistGoal.IsCompleted)
            {
                _score += checklistGoal.BonusPoints;
            }

            // Leveling up mechanism
            if (_score >= _level * 1000)
            {
                _level++;
                Console.WriteLine($"Congratulations! You've leveled up to Level {_level}.");
            }
        }
        else
        {
            Console.WriteLine("Goal not found.");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Your score is: {_score}");
        Console.WriteLine($"Your level is: {_level}");
    }

    public void ShowGoals()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(_score);
            writer.WriteLine(_level); // Save level
            foreach (var goal in _goals)
            {
                writer.WriteLine($"{goal.GetType().Name},{goal.Name},{goal.Points},{goal.IsCompleted}");
                if (goal is ChecklistGoal checklistGoal)
                {
                    writer.WriteLine($"{checklistGoal.TargetCount},{checklistGoal.CurrentCount},{checklistGoal.BonusPoints}");
                }
            }
        }
        Console.WriteLine("Goals saved.");
    }

    public void LoadGoals()
    {
        if (File.Exists("goals.txt"))
        {
            using (StreamReader reader = new StreamReader("goals.txt"))
            {
                _score = int.Parse(reader.ReadLine());
                _level = int.Parse(reader.ReadLine()); // Load level
                _goals.Clear();
                while (!reader.EndOfStream)
                {
                    string[] goalData = reader.ReadLine().Split(',');
                    string goalType = goalData[0];
                    string name = goalData[1];
                    int points = int.Parse(goalData[2]);
                    bool isCompleted = bool.Parse(goalData[3]);

                    switch (goalType)
                    {
                        case "SimpleGoal":
                            _goals.Add(new SimpleGoal(name, points) { IsCompleted = isCompleted });
                            break;
                        case "EternalGoal":
                            _goals.Add(new EternalGoal(name, points) { IsCompleted = isCompleted });
                            break;
                        case "ChecklistGoal":
                            int targetCount = int.Parse(reader.ReadLine());
                            int currentCount = int.Parse(reader.ReadLine());
                            int bonusPoints = int.Parse(reader.ReadLine());
                            _goals.Add(new ChecklistGoal(name, points, targetCount, bonusPoints)
                            {
                                IsCompleted = isCompleted,
                                CurrentCount = currentCount
                            });
                            break;
                    }
                }
            }
            Console.WriteLine("Goals loaded.");
        }
        else
        {
            Console.WriteLine("No saved goals found.");
        }
    }
}

class Program
{
    static void Main()
    {
        GoalManager manager = new GoalManager();
        string filename = "goals.txt";
        
        while (true)
        {
            Console.WriteLine("\n🎯 Eternal Quest - Goal Tracker 🎯");
            Console.WriteLine("1. Add Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter goal name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter point value: ");
                    int points = int.Parse(Console.ReadLine());
                    Console.Write("Goal Type (1=Simple, 2=Eternal, 3=Checklist): ");
                    int type = int.Parse(Console.ReadLine());
                    if (type == 1)
                        manager.AddGoal(new SimpleGoal(name, points));
                    else if (type == 2)
                        manager.AddGoal(new EternalGoal(name, points));
                    else
                    {
                        Console.Write("Enter target count: ");
                        int target = int.Parse(Console.ReadLine());
                        Console.Write("Enter bonus points: ");
                        int bonus = int.Parse(Console.ReadLine());
                        manager.AddGoal(new ChecklistGoal(name, points, target, bonus));
                    }
                    break;
                case "2":
                    Console.Write("Enter goal name to record: ");
                    manager.RecordEvent(Console.ReadLine());
                    break;
                case "3":
                    manager.DisplayGoals();
                    break;
                case "4":
                    manager.SaveGoals(filename);
                    break;
                case "5":
                    manager.LoadGoals(filename);
                    break;
                case "6":
                    return;
            }
        }
    }
}

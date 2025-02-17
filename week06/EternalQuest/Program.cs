using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        while (true)
        {
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Display Score");
            Console.WriteLine("4. Show Goals");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    goalManager.CreateNewGoal();
                    break;
                case "2":
                    goalManager.RecordEvent();
                    break;
                case "3":
                    goalManager.DisplayScore();
                    break;
                case "4":
                    goalManager.ShowGoals();
                    break;
                case "5":
                    goalManager.SaveGoals();
                    break;
                case "6":
                    goalManager.LoadGoals();
                    break;
                case "7":
                    return;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }
}

// Creativity: Added a leveling-up mechanism. Players level up when their score reaches multiples of 1000.

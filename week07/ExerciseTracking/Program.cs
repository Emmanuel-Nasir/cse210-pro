using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        while (true)
        {
            Console.WriteLine("Choose an activity to add:");
            Console.WriteLine("1. Running");
            Console.WriteLine("2. Cycling");
            Console.WriteLine("3. Swimming");
            Console.WriteLine("4. Exit and Display Summaries");

            string choice = Console.ReadLine();

            if (choice == "4")
            {
                break;
            }

            Console.Write("Enter the date (yyyy-mm-dd): ");
            DateTime date;
            while (!DateTime.TryParse(Console.ReadLine(), out date))
            {
                Console.Write("Invalid date format. Please enter the date (yyyy-mm-dd): ");
            }

            Console.Write("Enter the length ");
            int length;
            while (!int.TryParse(Console.ReadLine(), out length))
            {
                Console.Write("Invalid number. Please enter the length: ");
            }

            switch (choice)
            {
                case "1":
                    Console.Write("Enter the distance in kilometers: ");
                    double runningDistance;
                    while (!double.TryParse(Console.ReadLine(), out runningDistance))
                    {
                        Console.Write("Invalid number. Please enter the distance in kilometers: ");
                    }
                    activities.Add(new Running(date, length, runningDistance));
                    break;
                case "2":
                    Console.Write("Enter the speed in kilometers per hour: ");
                    double cyclingSpeed;
                    while (!double.TryParse(Console.ReadLine(), out cyclingSpeed))
                    {
                        Console.Write("Invalid number. Please enter the speed in kilometers per hour: ");
                    }
                    activities.Add(new Cycling(date, length, cyclingSpeed));
                    break;
                case "3":
                    Console.Write("Enter the number of laps: ");
                    int swimmingLaps;
                    while (!int.TryParse(Console.ReadLine(), out swimmingLaps))
                    {
                        Console.Write("Invalid number. Please enter the number of laps: ");
                    }
                    activities.Add(new Swimming(date, length, swimmingLaps));
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}

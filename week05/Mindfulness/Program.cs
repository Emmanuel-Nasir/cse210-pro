using System;

class Program
{
    static void Main(string[] args)
    {
        while (true){
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            if (choice == "4") break;

            Console.Write("Enter duration (in seconds):");
            int duration = int.Parse(Console.ReadLine());

            switch(choice)
            {
                case"1":
                    new BreathingActivity(duration).StartBreathing();
                    break;
                case"2":
                    new ReflectionActivity(duration).StartReflection();
                    break;
                case"3":
                    new ListingActivity(duration).StartListing();
                    break;
                default:
                    Console.WriteLine("Invalid choice, try again.");
                    break;
            }
        }
        Console.WriteLine("Goodbye!");
    }
}
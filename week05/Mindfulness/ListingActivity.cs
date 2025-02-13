using System;
using System.Collections.Generic;
using System.Threading;

class ListingActivity : MindfulnessActivity
{
    private static readonly List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt peace this month?",
        "Who are some of your personal heroes?"
    };
    public ListingActivity(int duration) : base(duration, "Listing", "This activity will help you reflect on the good things in your life.") { }

    public void StartListing()
    {
        StartMessage();

        Random rand = new Random();
        string selectedPrompt = prompts[rand.Next(prompts.Count)];
        Console.WriteLine($"\n--- {selectedPrompt} ---");
        PauseWithAnimation(5);

        List<string> responses = new List<string>();

        Console.WriteLine("\nStart listing! Type as many as you can:");

        int elapsedTime = 0;
        while (elapsedTime < _duration)
        {
            Console.Write("> ");
            responses.Add(Console.ReadLine());
            elapsedTime += 2;
        }

        Console.WriteLine($"\nYou listed {responses.Count} items!");
        EndMessage("Listing");
    }
    }
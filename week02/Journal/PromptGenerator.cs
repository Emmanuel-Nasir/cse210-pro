using System;
using System.Collections.Generic;
public class PromptGenerator{
    private List<string> _prompts =
    [
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What will I do to be a better person",
        "Did I study my scripture today?",
        "what was the worst part of my day"
    ];

    private Random _random = new();
    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
    public void AddNewPrompt(string newPrompt){
        _prompts.Add(newPrompt);
        Console.WriteLine("\n🆕The prompt has been added successfully!");
    }
}
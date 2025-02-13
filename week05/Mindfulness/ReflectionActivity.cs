using System;
using System.Collections.Generic;
using System.Threading;
class ReflectionActivity : MindfulnessActivity
{
    private static readonly List<string> prompts = new List<string>{
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
    };
    private static readonly List<string> questions = new List<string>{
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    };
    public ReflectionActivity(int duration) : base(duration, "Reflection","This activity will help you reflect on past experiences when you showed strength and resilience.") { }
    public void StartReflection(){
        StartMessage();
        Random rand = new Random();
        string selectedPrompt= prompts[rand.Next(prompts.Count)];
        Console.WriteLine($"\n---{selectedPrompt}---");
        PauseWithAnimation(5);

        int elapsedTime = 0;
        while (elapsedTime < _duration){
            string question = questions[rand.Next(questions.Count)];
            Console.WriteLine ($"\n{question}");
            PauseWithAnimation(5);
            elapsedTime+=5;
        }
        EndMessage("Reflection");
    }
}
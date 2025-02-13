using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
class MindfulnessActivity{
    protected int _duration;
    protected string _activityName;
    protected string _description;
  

    public MindfulnessActivity(int duration, string name, string description)
        {
            _duration = duration;
            _activityName = name;
            _description = description;
        }
    public void StartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName} Activity.");
        Console.WriteLine(_description);
        Console.WriteLine($"This session will last {_duration} seconds.");
        Console.WriteLine("Get ready...");
        PauseWithAnimation(3);
    }
    public void EndMessage(string name){
        Console.WriteLine("\nYou are doing well!");
        Console.WriteLine($"You have comepleted the {name} Activity for the {_duration} seconds.");
    }
    public void SaveLog(string activityName, int duration)
    {
        string logEntry = $"{DateTime.Now}: {activityName} Activity - {duration} seconds\n";
        File.AppendAllText("mindfulness_log.txt",logEntry);
        Console.WriteLine("\n[✔] Session saved to mindfulness_log.txt");
    }
    public void PauseWithAnimation(int seconds){
        for (int i = seconds; i>0; i--)
        {
            Console.Write($"\r starting in {i}...");
            Thread.Sleep(1000);
        }
        Console.WriteLine("\n");
    }
}
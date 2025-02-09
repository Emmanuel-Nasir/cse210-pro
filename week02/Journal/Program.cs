using System;

class Program
{
    static void Main()
    {
        Journal myJournal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();
        bool running = true;
        while(running){
            Console.WriteLine("\n📓 Journal Menu:");
            Console.WriteLine("1️⃣ Write a new entry");
            Console.WriteLine("2️⃣ Display all entries");
            Console.WriteLine("3️⃣ Save journal to file");
            Console.WriteLine("4️⃣ Load journal from file");
            Console.WriteLine("5️⃣ Add a new prompt");
            Console.WriteLine("6️⃣ Exit");
            Console.Write("👉 Choose an option: ");
            string choice = Console.ReadLine();
             switch (choice)
            {
                case "1":
                    WriteEntry(myJournal, promptGen);
                    break;
                case "2":
                    myJournal.DisplayAll();
                    break;
                case "3":
                    SaveJournal(myJournal);
                    break;
                case "4":
                    LoadJournal(myJournal);
                    break;
                case "5":
                    AddNewPrompt(promptGen);
                    break;
                case "6":
                    running = false;
                    Console.WriteLine("\n👋 Goodbye!");
                    break;
                default:
                    Console.WriteLine("\n❌ Invalid option. Try again.");
                    break;
            }
        }
    }
    static void WriteEntry(Journal journal, PromptGenerator promptGen){
        string prompt = promptGen.GetRandomPrompt();
        Console.WriteLine($"\n📑Prompt: {prompt}");
        Console.Write("🖊Your response: ");
        string response = Console.ReadLine();
        string date = DateTime.Now.ToString("yyyy-MM-dd");
        
        Entry newEntry = new Entry(date, prompt, response);
        journal.AddEntry(newEntry);
    }
    static void SaveJournal(Journal journal){
        Console.Write("💾 Enter filename to save:");
        string file = Console.ReadLine();
        journal.SaveToFile(file);
    }
    static void LoadJournal(Journal journal){
        Console.Write("📂Enter the name of the file to open it: ");
        string file = Console.ReadLine();
        journal.LoadFromFile(file);
    }
    
    static void AddNewPrompt(PromptGenerator promptGen)
    {
        Console.Write("🆕 Enter new prompt: ");
        string newPrompt = Console.ReadLine();
        promptGen.AddNewPrompt(newPrompt);
    }
}
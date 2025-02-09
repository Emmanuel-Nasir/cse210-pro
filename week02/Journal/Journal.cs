using System;
using System.Collections.Generic;
using System.IO;
public class Journal{
    private List<Entry> _enteries = new List<Entry>();
    public void AddEntry(Entry newEntry){
        _enteries.Add(newEntry);
        Console.WriteLine("\n✅ Entry added successfully!");
    }
    public void DisplayAll(){
        if(_enteries.Count==0)
        {
            Console.WriteLine("\n📖 No journal entries found.");
            return;
        }
        Console.WriteLine("\n📑 Journal Entries:");
        foreach (var entry in _enteries){
            entry.Display();
        }
    }
    public void SaveToFile(string file){
        try
        {
            using (StreamWriter writer = new StreamWriter(file)){
                foreach (Entry entry in _enteries){
                    writer.WriteLine(entry.ToCsv());
                }
            }
            Console.WriteLine("\n💾 The Journal has been successfully saved!");
        }
        catch (Exception e){
            Console.WriteLine($"👎Error saving file: {e.Message}");
        }
    }
    public void LoadFromFile(string file){
        try{
            if (!File.Exists(file)){
                Console.WriteLine("\n⚠️ File not found.");
                return;
            }
            _enteries.Clear();
            string[] lines = File.ReadAllLines(file);
            foreach (string line in lines)
            {
                _enteries.Add(Entry.FromCsv(line));
            }
            Console.WriteLine("\n📁The Journal has been loaded successfully!");
        }
        catch (Exception e){
            Console.WriteLine($"👎Error while loading file:{e.Message}");
        }
    }
}
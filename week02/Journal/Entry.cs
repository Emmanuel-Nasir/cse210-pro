using System;
public class Entry {
    public string Date{get;set; }
    public string PromptTest{get;set;}
    public string EntryTest {get;set;}
    public Entry(string date, string prompt, string entry)
    {
        Date = date;
        PromptTest=prompt;
        EntryTest=entry;
    }
    public void Display(){
        Console.WriteLine($"\n📅 _date: {Date}");
        Console.WriteLine($"📝 _promptTest: {PromptTest}");
        Console.WriteLine($"✏️ _entryTest: {EntryTest}");
    }
    public string ToCsv()
    {
        return $"{Date}|{PromptTest}|{EntryTest}";
    }
    public static Entry FromCsv(string csvLIne)
    {
        string[]parts = csvLIne.Split('|');
        return new Entry(parts[0],parts[1],parts[2]);
    }
}


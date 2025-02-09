using System;
class ScriptureReference{
    public string Book {get;}
    public int Chapter {get;}
    public int StartVerse{get;}
    public int? EndVerse {get;}

    public ScriptureReference(string book, int chapter, int startVerse, int? endVerse = null)
    {
        Book =book;
        Chapter = chapter;
        StartVerse = startVerse;
        EndVerse = endVerse;
    }
    public override string ToString()
    {
        return EndVerse == null ? $"{Book} {Chapter} : {StartVerse}" :$"{Book} {Chapter}:{StartVerse}-{EndVerse}";  
    }
}
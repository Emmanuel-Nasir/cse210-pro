using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    public ScriptureReference Reference { get; }
    private List<Word> Words { get; }

    public Scripture(ScriptureReference reference, string text)
    {
        Reference = reference;
        Words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int count)
    {
        Random rand = new Random();
        var wordsToHide = Words.Where(w => !w.IsHidden).OrderBy(_ => rand.Next()).Take(count);

        foreach (var word in wordsToHide)
        {
            word.Hide();
        }
    }

    public bool IsCompletelyHidden()
    {
        return Words.All(word => word.IsHidden);
    }

    public override string ToString()
    {
        return $"{Reference}\n" + string.Join(" ", Words);
    }
}

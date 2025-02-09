using System;

class Program
{
    static void Main(string[] args)
    {
        ScriptureReference reference = new ScriptureReference("Helaman",5,12);
        Scripture scripture = new Scripture(reference,"And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall.");
        while (true){
            Console.Clear();
            Console.WriteLine(scripture);
            Console.WriteLine("\nPress enter to hide the words or type 'quit' to close this program");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            break;
            scripture.HideRandomWords(3);

            if (scripture.IsCompletelyHidden()){
                Console.Clear();
                Console.WriteLine(scripture);
                Console.WriteLine("\nAll words are now hidden. BYE!");
                break;
            }
        }
    }
}
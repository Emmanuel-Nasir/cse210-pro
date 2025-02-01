using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("what is your name? ");
        string firstname = Console.ReadLine();

        Console.Write("what is your grade? ");
        string x = Console.ReadLine();
        int percent = int.Parse(x);
        string letter = "";

        int r = 97;
        int g = 93;
        int t = 90;
        int v = 80;
        int w = 70;
        int m = 60;
       if ( percent>= r)
       {
        letter = "A+";
       }
        else if ( percent>= g)
       {
        letter = "A-";
       }
      else if ( percent>= t)
       {
        letter = "A";
       }
       else if ( percent>= v)
       {
        letter = "B";
       }
       else if ( percent>= w)
       {
        letter = "C";
       }
       else if ( percent>= m)
       {
        letter = "D";
       }
       else if (percent<m)
       {
        letter = "F";
       }
       Console.WriteLine($"Your grade is: {letter}");
       if (percent >= 70)
       {
        Console.WriteLine("Congratulations, you have passed the grades!");
       }
       else
       {
        Console.WriteLine("You tried your best, strive harder next time!");
       }
    }
}
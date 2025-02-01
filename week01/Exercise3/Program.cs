using System;
using System.Net;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hello User, Welcome to the magic number game.you are to guess the magic number. It is being chosen randomly 😊");
        Random randomGuess = new Random();
        int magicNumber = randomGuess.Next(1,10);
        int guess = -1;
        while(guess != magicNumber){
            Console.WriteLine("Guess the magic number ");
            guess = int.Parse(Console.ReadLine());
            
            if (guess>magicNumber)
            {
                Console.Write("You are wrong! your guess is higher");
            }else if(guess<magicNumber){
                Console.Write("You are wrong! your guess is lower");
            }else{
                Console.Write("You are so lucky, Your guess is correct!");   
             }
        }
    }
}
using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers=new List<int>();
        int enteredNUmber = -1;
        while(enteredNUmber!=0){
            Console.Write("Enter a list of number of your choicewhen you are done, type 0 to end program");
            string answer = Console.ReadLine(); 
            enteredNUmber=int.Parse(answer);
        
        if (enteredNUmber !=0){
            numbers.Add(enteredNUmber);
        }
        }
        int addition = 0;
        foreach(int number in numbers){
            addition+= number;
        }
        Console.WriteLine($"The total sum of the numbers is {addition}");
        float average = ((float)addition)/ numbers.Count;
        Console.WriteLine($"The total average of the numbers is {average}");

        int maximum = 0;
        foreach (int number in numbers)
        {
            if (number > maximum)
            {
                maximum = number;
            }
        }
          Console.WriteLine($"The maximum number is: {maximum}"); 
        }
}
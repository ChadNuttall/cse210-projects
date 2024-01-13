using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their fist name
        Console.Write("What is you first name? ");
        string first = Console.ReadLine();

        // Ask the user for their last name
        Console.Write("What is you last name? ");
        string last = Console.ReadLine();      

        // Display message to user
        Console.WriteLine($"Your name is {last}, {first} {last}.");

    }
}
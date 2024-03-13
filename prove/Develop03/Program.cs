using System;

class Program
{
        static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", "3", "5-6");
        Scripture scripture = new Scripture("Trust in the Lord with all thine heart and understanding; in all thy ways acknowledge him, and he shall direct thy paths.");
        Words Words = new Words(reference, scripture);

        string userInput = "";

        // Loop until the user types "quit" or all words are hidden
        while (userInput != "quit" && Words.RemainingWords())
        {
            Console.Clear();
            Console.WriteLine($"{Words.ToString()}\n"); // Display the most current version of scripture with hidden words
            Console.WriteLine("Press enter to continue or type \"quit\" to exit:"); // User's Prompt
            userInput = Console.ReadLine();
            Words.HideWords(); // Initiate word hiding
        }

        Console.Clear();
        Console.WriteLine($"{Words.ToString()}\n"); // Display the most current version of scripture with all words hidden
        Console.WriteLine("You've memorized Proverbs 3:5-6!");
    }
}
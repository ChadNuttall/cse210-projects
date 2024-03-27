using System;

// Class for reflecting activity. Inheriting from Activity
public class ReflectingActivity : Activity
{
    // Fields for storing prompts and questions
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity() : base()
    {
        SetActivityName("Reflection Activity");

        SetActivityDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

        // List of prompts
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        // List of questions
        _questions = new List<string> 
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public void RunReflectingActivity()
    {
        ActivityStartingMessage();
        DisplayPrompt();
        DisplayQuestions();
        ActivityEndMessage();
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following: ");
        Console.WriteLine();

        int randomIndex = new Random().Next(0, _prompts.Count()); // Generate a random index
        Console.WriteLine(_prompts[randomIndex]); // Display the selected random prompt
        Console.WriteLine();

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
    }    

    public void DisplayQuestions()
    {
        List<int> indexes = new List<int>();

        for (int i = 0; i < 4; i++)
        {
            int randomInt = new Random().Next(0, _questions.Count()); // Generate a random index
            while (indexes.Contains(randomInt))
            {
                randomInt = new Random().Next(0, _questions.Count()); // Ensure there are no duplicates
            }
            indexes.Add(randomInt);
        }
        Console.Clear();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.WriteLine();
        Animation.DislplayCountDown(5);

        foreach (int index in indexes)
        {
            Console.Write(_questions[index]);
            Animation.DisplaySpinner((GetSessionLength() / indexes.Count()));
            Console.WriteLine();
        }
        
    }

        
}
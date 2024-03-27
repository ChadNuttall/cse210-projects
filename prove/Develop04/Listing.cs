using System;

// Class for Listing activity. Inheriting from Activity
public class ListingActivity : Activity
{
    // Fields for storing random prompts and prompts
    private string _randomPrompt { get; set; }
    private List<string> _prompts;

    public ListingActivity() : base()
    {
        SetActivityName("Listing Activity");
        SetActivityDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        // List of Prompts
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }


    public void RunListingActivity()
    {
        ActivityStartingMessage();
        DisplayPrompt();
        ListingCounter();
        ActivityEndMessage();
    }
    private void DisplayPrompt()
    {
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();
        int randomIndex = new Random().Next(0, _prompts.Count()); // Generate a random index
        Console.WriteLine(_prompts[randomIndex]); // Display the selected random prompt
        Console.WriteLine();
    }

    private void ListingCounter()
    {
         DateTime startTime = DateTime.Now; // Get the Current time
        DateTime futureTime = startTime.AddSeconds(GetSessionLength()); // Calculate future time by adding session length
        DateTime currentTime = DateTime.Now;
        int listCount = 0;
        // Loop until current time exceeds future time
        while (currentTime < futureTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            listCount += 1;
            currentTime = DateTime.Now; // Update current time
        }
        Console.WriteLine();
        Console.WriteLine($"You listed {listCount} items.");
        Animation.DisplaySpinner(5);
    }
}

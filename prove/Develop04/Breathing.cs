using System;

// Class for breathing activity. Inheriting from Activity
public class BreathingActivity : Activity
{
    public BreathingActivity() : base()
    {
        SetActivityName("Breathing Activity");

        SetActivityDescription("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
    }

    public void RunBreathingActivity()
    {
        ActivityStartingMessage();
        DisplayBreathing();
        ActivityEndMessage();
    }

    public void DisplayBreathing()
    {
        int runTime = GetSessionLength() * 1000; // Convert from seconds to milliseconds
        int intervalTime = 10000; // Interval time for breathing in and out
        int intervals = runTime / intervalTime; // Calculate number of intervals based on session length

        for(int i = 0; i < intervals; i++)
        {
            Console.Write("Breathe in... ");
            Animation.DislplayCountDown(4);
            Console.WriteLine();
            
            Console.Write("Breathe out... "); 
            Animation.DislplayCountDown(6);
            Console.WriteLine();
        }
    }
}
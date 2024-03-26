using System;

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
        int runTime = GetSessionLength() * 1000;
        int intervalTime = 10000;
        int intervals = runTime / intervalTime;

        for(int i = 0; i < intervals; i++)
        {
            Console.Write("Breathe in... ");
            Animation.CountIn();
            Console.WriteLine();
            
            Console.Write("Breathe out... "); 
            Animation.CountOut();
            Console.WriteLine();
        }
    }
}
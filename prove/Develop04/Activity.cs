using System;

public class Activity
{
    protected string _startingMessage;
    protected string _endingMessage;
    protected string _activityDescription;
    protected string _activityName;
    static int _SessionLength = 0;

    public void SetActivityName(string activityName)
    {
        _activityName = activityName;
    }

    public void SetActivityDescription(string activityDescription)
    {
        _activityDescription = activityDescription;
    }

    public int GetSessionLength()
    {
        return _SessionLength;
    }

    public void DisplayStartingMessage()
    {
        _startingMessage = $"Welcome to the {_activityName}.";
        Console.WriteLine(_startingMessage);
        Console.WriteLine();
    }

    public void DisplayDescription()
    {
        Console.WriteLine(_activityDescription);
        Console.WriteLine();
    }

    public void DisplayEndingMessage()
    {
        _endingMessage = $"You have completed {_SessionLength} seconds of the {_activityName}.";

        Console.WriteLine();
        Console.WriteLine("Well done!");
        Animation.DisplaySpinner(3);
        Console.WriteLine();
        Console.WriteLine(_endingMessage);
        Animation.DisplaySpinner(5);
        Console.Clear();
    }

    public void DisplayGetSessionLength()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        _SessionLength = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        Animation.DisplaySpinner(1);
    }

    public void ActivityStartingMessage()
    {
        DisplayStartingMessage();
        DisplayDescription();
        DisplayGetSessionLength();
        Console.Clear();
    }

    public void ActivityEndMessage()
    {
        DisplayEndingMessage();
    }
}
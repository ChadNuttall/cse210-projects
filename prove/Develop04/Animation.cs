using System;

public static class Animation
{
    //Spinner Animation
    public static void DisplaySpinner(int runTime)
    {
        List<string> spinnerCharacters = new List<string>();
        spinnerCharacters.Add("|");
        spinnerCharacters.Add("/");
        spinnerCharacters.Add("-");
        spinnerCharacters.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(runTime);
        int spinCount = 0;

       while (DateTime.Now < endTime)
       {
            string character = spinnerCharacters[spinCount];
            Console.Write(character);
            Thread.Sleep(750);
            Console.Write("\b \b");
            
            spinCount++;

            if (spinCount >= spinnerCharacters.Count){
                spinCount = 0;
            }

        }

        Console.Write(" ");
    }
    //Breathing Animations
    //Breath In
    public static void CountIn()
    {
        for (int i = 4; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    //Breath Out
    public static void CountOut()
    {
        for (int i = 6; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}

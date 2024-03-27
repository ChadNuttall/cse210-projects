using System;

public static class Animation
{
    private static List<string> _spinnerCharacters;

    //Spinner Animation
    public static void DisplaySpinner(int runTime)
    {
        _spinnerCharacters = new List<string>{
            "|",
            "/",
            "-",
            "\\"
        };

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(runTime);
        int spinCount = 0;

       while (DateTime.Now < endTime)
       {
            string character = _spinnerCharacters[spinCount];
            Console.Write(character);
            Thread.Sleep(750);
            Console.Write("\b \b");
            
            spinCount++;

            if (spinCount >= _spinnerCharacters.Count){
                spinCount = 0;
            }

        }

        Console.Write(" ");
    }

    //Count Down Animation
    public static void DislplayCountDown(int runTime)
    {
        for (int i = runTime; i > 0; i--){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}

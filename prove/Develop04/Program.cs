using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("Welcome to the Mindfulness Program!");
        Console.WriteLine();
        bool running = true;
        while (running)
        {
            Console.WriteLine("Please select one of the following activities: ");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine();
            Console.Write("What would you like to do? ");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {   
                //Breathing
                case 1:
                    Console.Clear();
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.RunBreathingActivity();
                    break;
                //Reflecting
                case 2:
                    Console.Clear();
                    Console.WriteLine("Reflecting Activity is under constuction.\n");
                    break;
                //Listing
                case 3:
                    Console.Clear();
                    Console.WriteLine("Listing Activity is under constuction.\n");
                    break;
                //Quit
                case 4:
                    Console.Clear();
                    running = false;
                    Console.WriteLine("Have a nice day!");
                    break;
            }
     
        }
    }
}
using System;
// Showing Creativity and Exceeding Requirements
// Error Handling
// Keeping a log of how many of each activity was performed.
class Program
{
    static void Main(string[] args)
    {   
        // Counters to keep track of how many times each activity is performed
        int breathingCount = 0;
        int reflectingCount = 0;
        int listingCount = 0;

        Console.WriteLine("Welcome to the Mindfulness Program!");
        Console.WriteLine();
        bool running = true;
        while (running)
        {
            // Display menu options
            Console.WriteLine("Please select one of the following activities: ");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine();
            Console.Write("What would you like to do? ");
            // Take user input
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {   
                //Breathing
                case 1:
                    Console.Clear();
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.RunBreathingActivity();
                    breathingCount++;
                    break;
                //Reflecting
                case 2:
                    Console.Clear();
                    ReflectingActivity reflecting = new ReflectingActivity();
                    reflecting.RunReflectingActivity();
                    reflectingCount++;
                    break;
                //Listing
                case 3:
                    Console.Clear();
                    ListingActivity listing = new ListingActivity();
                    listing.RunListingActivity();
                    listingCount++;
                    break;
                //Quit
                case 4:
                    Console.Clear();
                    running = false;
                    if (breathingCount != 0 || reflectingCount != 0 || listingCount != 0)
                    {
                        Console.WriteLine("Well Done! You completed the following activities: ");
                        if (breathingCount > 0)
                        {
                            Console.WriteLine($"Breathing Activity: {breathingCount} time(s)");
                        };
                        if (reflectingCount > 0)
                        {
                            Console.WriteLine($"Reflecting Activity: {reflectingCount} time(s)");
                        };
                        if (listingCount > 0)
                        {
                            Console.WriteLine($"Listing Activity: {listingCount} time(s)");
                        };
                    };
                    Console.WriteLine();
                    Console.WriteLine("Have a nice day!");
                    break;
                //Error Handling
                default:
                        Console.WriteLine();
                        Console.WriteLine("Invalid Entry.");
                        Console.WriteLine("Please enter a valid entry.");
                        Console.WriteLine();
                        break;
            }
     
        }
    }
}
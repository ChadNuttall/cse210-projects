using System;

namespace DailyJournal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to the Journal Program!");

            Journal journal = new Journal();

            List<string> prompts = new List<string>
            {
                "How did I see the hand of the Lord in my life today? ",
                "What was the most challenging thing you faced today and how did you overcome it? ",
                "What made you smile today?" ,
                "What did you do today that took you out of your comfort zone? ",
                "What do you most wish for tomorrow? "
            };

            bool quit = false;
            while (!quit)
            {
                Console.WriteLine("\nThe Journal Program");
                Console.WriteLine("Please enter one:");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Save");
                Console.WriteLine("4. Load");
                Console.WriteLine("5. Quit");

                Console.WriteLine("\nWhat would you like to do? ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        string prompt = GetRandomPrompt(prompts);
                        journal.AddEntry(prompt);
                        break;
                    case "2":
                        journal.DisplayEntries();
                        break;
                    case "3":
                        journal.SaveToFile();
                        break;
                    case "4":
                        journal.LoadFromFile();
                        break;
                    case "5":
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("\nInvalid Entry.\nPlease enter a valid entry.");
                        break;
                }
            }
            Console.WriteLine("\nUntil next time, keep writing!\n");
        }

        static string GetRandomPrompt(List<string> prompts)
        {
            Random random = new Random();
            int index = random.Next(prompts.Count);
            return prompts[index];
        }
    }
}
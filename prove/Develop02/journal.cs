using System;

namespace DailyJournal
{
    class Journal
    {
        public List<Entry> entries;

        public Journal()
        {
            entries = new List<Entry>();
        }

        public void AddEntry(string prompt)
        {
            Console.Write(prompt + " ");
            string response = Console.ReadLine();
            string date = DateTime.Now.ToString("MM/dd/yyyy");
            entries.Add(new Entry(prompt, response, date));
        }

        public void DisplayEntries()
        {
            if (entries == null || entries.Count == 0)
            {
                Console.WriteLine("\nNo Entries loaded.\nPlease Load an Entry.");
            }
            else
            {
                foreach (Entry entry in entries)
                {
                    Console.WriteLine(entry.ToString());
                }
            }
        }
        public void SaveToFile()
        {
            Console.Write("\nEnter Filename: ");
            string filename = Console.ReadLine();

            if (entries == null || entries.Count == 0)
            {
                Console.WriteLine("\nError:\nNo Entry Saved!");
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(filename))
                {
                writer.WriteLine("Date,Prompt,Response");

                foreach (Entry entry in entries)
                {
                    writer.WriteLine($"{entry.GetDate()},{entry.GetPrompt().Replace(",", ",,")},{entry.GetResponse().Replace(",", ",,")}");
                }
                }
            }

            Console.WriteLine("Saved");
        }

        public void LoadFromFile()
        {
            Console.Write("Enter filename: ");
            string filename = Console.ReadLine();
            entries.Clear();
            
            if (!File.Exists(filename))
            {
                Console.WriteLine("File not found.");
                return;
            }
            else{
                using (StreamReader reader = new StreamReader(filename))
                {
                string headerLine = reader.ReadLine(); // Read and discard the header line

                while (!reader.EndOfStream)
                {
                    string entryLine = reader.ReadLine();
                    string[] fields = entryLine.Split(',');

                    string date = fields[0];
                    string prompt = fields[1].Replace(",,", ",");
                    string response = fields[2].Replace(",,", ",");

                    entries.Add(new Entry(prompt, response, date));
                }
                }
            }

            Console.WriteLine("Loaded");
        }
    }
}
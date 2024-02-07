using System;

namespace DailyJournal
{
    class Journal
    {
        public List<Entry> entries; // Make a list of Entries. Put inside that list each Entry

        public Journal()
        {
            entries = new List<Entry>(); // See Learning 02 line 4
        }

        public void AddEntry(string prompt)
        {
            Console.Write(prompt + " ");
            string response = Console.ReadLine(); // I needed to make the response a variable in order to reference it as an entry in my list of entries.
            string date = DateTime.Now.ToString("MM/dd/yyyy"); // Get the date using DateTime. Now use ToString to instruct it to follow MM/dd/yyyy format
            entries.Add(new Entry(prompt, response, date)); // An Entry will include the prompt (to provide context), the response to the prompt, and the date. Each as seperate entities so if needed they can be called on seperately.
        }

        public void DisplayEntries()
        {
            if (entries == null || entries.Count == 0) // In the case that there is nothing entered or there are no entries cued. Give error message.
            {
                Console.WriteLine("\nNo Entries loaded.\nPlease Load an Entry."); // Error message
            }
            else
            {
                foreach (Entry entry in entries) // From the loaded Entries
                {
                    Console.WriteLine(entry.ToString()); // Write what is in entry to follow the ToString instructions (Entry line 35)
                }
            }
        }
        public void SaveToFile()
        {
            Console.Write("\nEnter Filename: "); // Prompt for filename to be saved
            string filename = Console.ReadLine();

            if (entries == null || entries.Count == 0) // In the case that there is nothing entered or there are no entries cued. Give error message.
            {
                Console.WriteLine("\nError:\nNo Entry Saved!"); // Error Message
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(filename)) // Used StreamWriter as shown in the "Writing Text Files in C#"
                {
                writer.WriteLine("Date,Prompt,Response");

                foreach (Entry entry in entries) // Iterate through each entry
                {
                    writer.WriteLine($"{entry.GetDate()},{entry.GetPrompt().Replace(",", ",,")},{entry.GetResponse().Replace(",", ",,")}"); // Pull each portion of entry into related portion of string to be displayed. Use .Replace to insert punctuation where needed.
                }
                }
            }

            Console.WriteLine("Saved"); // Inform user of task complete
        }

        public void LoadFromFile()
        {
            Console.Write("Enter filename: "); // Prompt for the file name
            string filename = Console.ReadLine(); // Save response to variable for search reffence
            entries.Clear(); // Discard user response
            
            if (!File.Exists(filename)) // Check to see if there is any filename. If the file is not in the list or if there was not entry give Error
            {
                Console.WriteLine("File not found."); // Error message
                return;
            }
            else{
                using (StreamReader reader = new StreamReader(filename)) // We were shown StreamWriter let's use StreamReader
                {
                string headerLine = reader.ReadLine(); // Read and discard the header line

                while (!reader.EndOfStream) // This is what we do with our stream. Using Richi Hindle's example (https://stackoverflow.com/questions/1307801/streamreader-endofstream-missing-last-line)
                {
                    string entryLine = reader.ReadLine();
                    string[] fields = entryLine.Split(',');

                    string date = fields[0]; // The first index is the date
                    string prompt = fields[1].Replace(",,", ","); // The next index is the prompt put commas there accordingly
                    string response = fields[2].Replace(",,", ","); // The Third index is the response put commas there accordingly

                    entries.Add(new Entry(prompt, response, date)); // Add prompt, response and date as an entry in Entry
                }
                }
            }

            Console.WriteLine("Loaded"); // Inform user that the file was loaded
        }
    }
}
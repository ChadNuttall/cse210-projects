using System;

namespace DailyJournal
{
    class Entry // This is patterned after Learning 02 Job.cs
    {
        public string _prompt;
        public string _response;
        public string _date;

        public Entry(string prompt, string response, string date)
        {
            _prompt = prompt; 
            _response = response;
            _date = date;
        }

        public string GetPrompt()
        {
            return _prompt;
        }

        public string GetResponse()
        {
            return _response;
        }

        public string GetDate()
        {
            return _date;
        }

        public override string ToString() // Overriding allows for sections to be described in final output as Date: Promt:
        {
            return $"\nDate: {_date} - Prompt: {_prompt} \n{_response}\n"; 
        }
    }
}
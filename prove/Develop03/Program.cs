using System;

class Program
{
        static void Main(string[] args)
    {
        Scripture scripture = new Scripture("Proverbs", "3", "5-6", "Trust in the Lord with all thine heart and understanding; in all thy ways acknowledge him, and he shall direct thy paths.");
        Console.WriteLine(scripture);
    }
}
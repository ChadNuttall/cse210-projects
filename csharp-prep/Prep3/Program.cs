using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.Write("What is the magic number? ");
        //int magic_number = int.Parse(Console.ReadLine());

        Random random_number = new Random();
        int magic_number = random_number.Next(1, 101);

        int guess = -1;

        while (guess != magic_number){
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
        
            if (guess > magic_number){
                Console.WriteLine("Lower");
            }else if (guess < magic_number){
                Console.WriteLine("Higher");
            }else {
                Console.WriteLine("You guessed the magic number!");
            }
        }
    }
}
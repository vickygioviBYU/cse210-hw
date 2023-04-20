using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumberInt = randomGenerator.Next(1, 100);

        int guessInt = -1;

        int guesses = 0;

        while (magicNumberInt != guessInt) {
            Console.WriteLine("What is your guess? ");
            string guess = Console.ReadLine();
            guesses++;
            guessInt = int.Parse(guess);

            if (magicNumberInt > guessInt) {
                Console.WriteLine("Higher");
            } else if (magicNumberInt < guessInt) {
                Console.WriteLine("Lower");
            } else {
                
            }
        }

        Console.WriteLine($"You guessed!! (Guesses: {guesses})");
        
    }
}
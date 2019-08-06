using System;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "giraffe";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            while (guess != secretWord && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter Guess:");

                    guess = Console.ReadLine();

                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }

                if (outOfGuesses)
                {
                    Console.WriteLine("You Lose");
                    Console.ReadLine();
                }
            }
            Console.Write("You Win!");
        }
    }
}

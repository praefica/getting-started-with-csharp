// https://www.microsoft.com/net/tutorials/csharp/getting-started/making-decisions

using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main()
        {
            int correctNumber = new Random().Next(4);
            Console.WriteLine("Please enter a number:");
            int guessedNumber = int.Parse(Console.ReadLine());
            if (guessedNumber < 1 || guessedNumber > 3)
            {
                Console.WriteLine("The number should be between 1 and 3.");
            }
            else if (guessedNumber < correctNumber)
            {
                Console.WriteLine("You guessed low.");
            }
            else if (guessedNumber > correctNumber)
            {
                Console.WriteLine("You guessed high.");
            }
            else
            {
                Console.WriteLine("You guessed the correct number!");
            }
        }
    }
}
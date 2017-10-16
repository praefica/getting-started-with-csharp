// https://www.microsoft.com/net/tutorials/csharp/getting-started/looping-logical-expression

using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Factors: ");
            while (number > 1)
            {
                int candidateFactor = 2;
                while (candidateFactor <= number)
                {
                    if (number % candidateFactor == 0)
                    {
                        Console.Write(candidateFactor);
                        number = number / candidateFactor;
                        if (number > 1) Console.Write(", ");
                    }
                    candidateFactor++;
                }
            }
            Console.WriteLine();
        }
    }
}
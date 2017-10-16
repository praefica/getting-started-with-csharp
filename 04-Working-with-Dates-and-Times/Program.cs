// https://www.microsoft.com/net/tutorials/csharp/getting-started/datetimes

using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main()
        {
            DateTime birthDate = new DateTime(1982, 8, 25);
            TimeSpan ageInDays = DateTime.Today - birthDate;
            int daysToNextAnniversary = 10000 - (ageInDays.Days % 10000);
            DateTime dateOfNextAnniversary = DateTime.Today.AddDays(daysToNextAnniversary);
            Console.WriteLine($"{dateOfNextAnniversary}");
        }
    }
}
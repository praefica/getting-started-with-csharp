// https://www.microsoft.com/net/tutorials/csharp/getting-started/logical-expressions

using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main()
        {
            int currentHour = DateTime.Now.Hour;
            bool isMorning = currentHour >= 6 && currentHour < 12;
            bool isAfternoon = currentHour >= 12 && currentHour < 18;
            bool isEvening = currentHour >= 18 && currentHour < 24;
            bool isNight = currentHour >= 0 && currentHour < 6;
            if (isMorning) Console.WriteLine("Good morning!");
            if (isAfternoon) Console.WriteLine("Good afternoon!");
            if (isEvening) Console.WriteLine("Good evening!");
            if (isNight) Console.WriteLine("Good Night!");
        }
    }
}

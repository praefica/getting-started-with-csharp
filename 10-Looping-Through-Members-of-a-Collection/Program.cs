// https://www.microsoft.com/net/tutorials/csharp/getting-started/looping-collections

using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main()
        {
            var myList = new List<int>() { 2, 4, 6 };
            int mySum = 0;
            Console.Write("Numbers: ");
            foreach (var number in myList)
            {
                Console.Write($"{number} ");
                mySum += number;
            }
            Console.WriteLine();
            Console.Write($"Sum: {mySum}");
        }
    }
}

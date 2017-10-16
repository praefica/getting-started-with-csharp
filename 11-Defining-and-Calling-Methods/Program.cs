// https://www.microsoft.com/net/tutorials/csharp/getting-started/methods

using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void displayNumbersInList(List<int> myList)
        {
            foreach (int number in myList)
            {
                Console.Write($"{number} ");
            }
        }

        public static void displaySumOfNumbersInList(List<int> myList)
        {
            int mySum = 0;
            foreach (int number in myList)
            {
                mySum += number;
            }
            Console.Write(mySum);
        }

        public static void Main()
        {
            var myList = new List<int>() { 2, 4, 6 };
            Console.Write("Numbers: ");
            displayNumbersInList(myList);
            Console.WriteLine();
            Console.Write("Sum: ");
            displaySumOfNumbersInList(myList);
        }
    }
}

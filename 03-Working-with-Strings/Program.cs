// https://www.microsoft.com/net/tutorials/csharp/getting-started/strings

using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main()
        {
            string greeting = "Hello";
            string name = "John";
            string sentence = $"{greeting}, {name}!";
            string mode = "loud";
            string line = "";
            if (mode == "loud") line = sentence.ToUpper();
            if (mode == "quiet") line = sentence.ToLower();
            else line = sentence;
            Console.WriteLine(line);
        }
    }
}
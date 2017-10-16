// https://www.microsoft.com/net/tutorials/csharp/getting-started/arrays-collections

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        while (true)
        {
            List<string> items = new List<string>();
            Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
            string commandItem = Console.ReadLine();
            string command = commandItem.Substring(0,2);
            string item = commandItem.Substring(2);
            switch (command)
            {
                case "+ ":
                    items.Add(item);
                    break;
                case "- ":
                    items.Remove(item);
                    break;
                case "--":
                    items.Clear();
                    break;
                default:
                    Console.WriteLine("Unknown command.");
                    break;
            }
            if (items.Count != 0)
            {
                Console.WriteLine("Your list: ");
                items.ForEach(Console.WriteLine);
            }
            else
            {
                Console.WriteLine("Empty list.");
            }
        }
    }
}
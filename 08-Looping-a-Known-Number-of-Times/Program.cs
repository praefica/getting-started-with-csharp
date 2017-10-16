// https://www.microsoft.com/net/tutorials/csharp/getting-started/for-loops

using System;

public class Program
{
    public static void Main()
    {
        for (int i = 1; i < 5; i++)
        {
            int limit = 24;
            for (int j = 0; j <= limit; j += i)
            {   
                if (j != limit) Console.Write($"{j},");
                else Console.Write(j);
            }
            Console.WriteLine();
        }
    }
}

// https://www.microsoft.com/net/tutorials/csharp/getting-started/exceptions

using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public class MyMissingTokenException : System.ArgumentException
            {
                public MyMissingTokenException() : base("Missing token exception.")
                { }
            }
            
        public class MyInvalidTokenException : System.ArgumentException
        {
            public MyInvalidTokenException(string token) : base($"Invalid token exception.\nToken: {token}")
            { }
        }
        
        public static List<string> GetAccessPermissions(string token)
        {
            int validLength = 8;
            if (token != null || token != String.Empty)
            {
                if (token.Length != validLength)
                {
                    throw new MyInvalidTokenException(token);
                }
                else
                {
                    return new List<string>{ "ReadLessons", "ReviewLessons" };     
                }
            }
            throw new MyMissingTokenException();
        }

        public static void Main()
        {
                List<string> list = GetAccessPermissions("12345678");
                foreach (string item in list)
                {
                    Console.WriteLine(item);
                }
        }
    }
}
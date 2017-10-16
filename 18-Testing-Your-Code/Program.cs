// https://www.microsoft.com/net/tutorials/csharp/getting-started/testing

using System;
using Xunit;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main()
        { }
    }

    // Unit Testing an Extension Method
    public static class ExtensionMethods
    {
        public static int PlusFive(this int input)
        {
            return input + 5;
        }
    }

    public class ExtensionMethodsPlusFiveShould
    {
        [Fact]
        public void ReturnFiveMoreThanInput()
        {
            //Arrange
            int input = 10;
            int expectedResult = 15;
        
            //Act
            int actualResult = input.PlusFive();
        
            //Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }

    // Unit Testing an Instance Method 
    // public class Utilities
    // {
    //     public int PlusFive(int input)
    //     {
    //         return input + 5;
    //     }
    // }

    // public class UtilitiesPlusFiveShould
    // {
    //     [Fact]
    //     public void ReturnFiveMoreThanInput()
    //     {
    //         //Arrange
    //         int input = 10;
    //         var utilities = new Utilities();
    //         int expectedResult = 15;

    //         //Act
    //         int actualResult = utilities.PlusFive(input);

    //         //Assert
    //         Assert.Equal(expectedResult, actualResult);
    //     }
    // }
}
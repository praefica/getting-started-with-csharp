// https://www.microsoft.com/net/tutorials/csharp/getting-started/linq

using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication
{
   public class Program
   {
       public class FullName
       {
           public string First { get; set; }
           public string Last { get; set; }
       }

       public class Person
       {
           public string FirstName { get; set; }
           public string LastName { get; set; }
           public string Occupation { get; set; }
           public int Age { get; set; }
       }
       
       public static List<Person> GenerateListOfPeople()
       {
           var people = new List<Person>();
           
           people.Add(new Person { FirstName = "John", LastName = "Doe", Occupation = "Manager", Age = 40});
           people.Add(new Person { FirstName = "Emma", LastName = "Smith", Occupation = "Developer", Age = 24});
           people.Add(new Person { FirstName = "Noah", LastName = "Johnson", Occupation = "Developer", Age = 30});
           people.Add(new Person { FirstName = "Olivia", LastName = "Williams", Occupation = "Developer", Age = 30});

           return people;
       }

       public static void Main()
       {
           List<Person> emptyList = new List<Person>();
           List<Person> people = GenerateListOfPeople();

           IEnumerable<Person> peopleOverTheAgeOf30 = people.Where(x => x.Age > 30);
           IEnumerable<Person> skipTwo = people.Skip(2);
           IEnumerable<Person> takeTwo = people.Take(2);
           IEnumerable<string> allFirstNames = people.Select(x => x.FirstName);
           IEnumerable<FullName> allFullNames = people.Select( x => new FullName { First = x.FirstName, Last = x.LastName });

           Person firstOrDefault = people.FirstOrDefault();
           Person firstThirtyYearOld = people.FirstOrDefault(x => x.Age == 30);
           Person willBeNull = emptyList.FirstOrDefault();
           Person willAlsoBeNull = people.FirstOrDefault(x => x.FirstName == "Emma");
           Person lastOrDefault = people.LastOrDefault();
           Person LastThirtyYearOld = people.LastOrDefault(x => x.Age == 30);
           Person singleJohn = people.SingleOrDefault(x => x.FirstName == "John");
           // The line below will raise System.InvalidOperationException
           // Person singleDev = people.SingleOrDefault(x => x.Occupation == "Developer");

           int numberOfPeopleInList = people.Count();
           int peopleOverTwentyFive = people.Count(x => x.Age > 25);

           bool thereArePeople = people.Any();
           bool thereAreNoPeople = emptyList.Any();
           bool allDevelopers = people.All(x => x.Occupation == "Developer");
           bool allAtLeastTwentyFour = people.All(x => x.Age >= 24);

           List<Person> listOfDevelopers = people.Where(x => x.Occupation == "Developer").ToList();
           Person[] arrayOfDevelopers = people.Where(x => x.Occupation == "Developer").ToArray();

           Console.WriteLine("--- FIND PERSON(S) BY AGE ---");
           Console.WriteLine("Please specify an age: ");
           int specifiedAge = int.Parse(Console.ReadLine());
           IEnumerable<Person> peopleOverSpecifiedAge = people.Where(x => x.Age > specifiedAge);
           Console.WriteLine("Found {0} person(s) over {1}.\n", peopleOverSpecifiedAge.Count(), specifiedAge);
           foreach (Person person in peopleOverSpecifiedAge)
           {
               Console.WriteLine($"Firstname: {person.FirstName}\tLastname: {person.LastName}\tOccupation: {person.Occupation}\tAge: {person.Age}\n");
           }

       }
   } 
}
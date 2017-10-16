// https://www.microsoft.com/net/tutorials/csharp/getting-started/scope-accessibility

using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Person
    {
        protected string FirstName { get; private set; }
        protected string LastName { get; private set; }
        public string FullName { get { return $"{this.FirstName} {this.LastName}"; } }
        public DateTime DateOfBirth { get; private set; }

        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
        }

        public bool IsAnAdult()
        {
            var eighteenYearsAgo = DateTime.Today.AddYears(-18);
            return this.DateOfBirth < eighteenYearsAgo;
        }
    }

    public class Student : Person
    {
        public string SchoolName { get; set; }
        public string RosterName { get { return $"{this.LastName}, {this.FirstName}"; } }

        public Student(string firstName, string lastName, DateTime dateOfBirth) : base(firstName, lastName, dateOfBirth)
        { }
    }

    public class Course
    {
        public string CourseName { get; private set; }
        private List<Student> EnrolledStudents { get; set; }

        public Course(string courseName)
        {
            this.CourseName = courseName;
            this.EnrolledStudents = new List<Student>();
        }

        public void Enroll(Student student)
        {
            EnrolledStudents.Add(student);
        }

        public List<string> Roster()
        {
            var roster = new List<string>();
            foreach (var student in EnrolledStudents)
            {
                roster.Add(student.RosterName);
            }
            return roster;
        }

    }

    public class Program
    {
        public static void Main()
        {
            var course = new Course(".NET Tutorials");
            var student1 = new Student("John", "Doe", DateTime.Parse("01/01/1981"));
            var student2 = new Student("Jane", "Doe", DateTime.Parse("02/02/1982"));

            course.Enroll(student1);
            course.Enroll(student2);

            Console.WriteLine(course.CourseName + "\n");
            Console.WriteLine(String.Join("\n", course.Roster()));
        }
    }
}
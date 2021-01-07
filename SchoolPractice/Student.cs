using System;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        //It's ok to have multiple constructors for a class!
            //1. Default constructor
        public Student() { }
            //2. Constructor w values as arguments
        public Student(string name, int id, int credits, double gpa)
        {
            this.Name = name;
            this.StudentId = id;
            this.NumberOfCredits = credits;
            this.Gpa = gpa;
        }
    }


}

using System;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {
        //public const double ////i totally spaced out on this example for constants.

        private static int currentID = 100;   //this is an example of a static field.

        //private readonly int id;
        public string Name { get; set; }
        public int StudentId {
            get { return id; }
            }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }


        //It's ok to have multiple constructors for a class!
            //1. Default constructor
        public Student() {
            this.Name = "";
            this.StudentId = -1;
            this.NumberOfCredits = 0;
            this.Gpa = 0.0;
        }

            //2. Constructor w values as arguments
        public Student(string name, int id, int credits, double gpa)
        {
            this.Name = name;
            this.StudentId = id;
            this.NumberOfCredits = credits;
            this.Gpa = gpa;
        }

        //3. Overloaded constructor
        // public ClassName(...subsetArgs) : this(...subsetArgs, defaultValues...)
        public Student(string _name, int _id) : this(_name, _id, 0, 0.0) //<-- last 2 are passed in from "this"
        { }

        //4. just creates an object w name and 3 defaults.
        public Student(string name)
        {
            this.Name = name;
            this.StudentId = currentID++;   //this is the static field we made.
            this.NumberOfCredits = 0;
            this.Gpa = 0.0;
        }            
    }
}

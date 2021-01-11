using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            Student me = new Student();

            me.Name = "Julie";
;           me.StudentId = 101;
            me.NumberOfCredits = 1;
            me.Gpa = 4.0;

            /*Console.WriteLine($"{me.Name} ({me.StudentId})");
            Console.WriteLine($"Credits: {me.NumberOfCredits}, GPA: {me.Gpa}");*/

            //generate a new course.
            Course basketWeaving = new Course();
            basketWeaving.Id = 8675309;
            basketWeaving.Name = "Music";
            basketWeaving.Length = 17;
            basketWeaving.NumCredits = 4;
            //creating new instance of list class below!
            basketWeaving.Roster = new List<Student>();

            //we want to add a reference to a student object here.
            basketWeaving.Roster.Add(me);
            basketWeaving.Roster.Add(new Student("Madison Clark", 104, 1, 3.80));     //  <--adding a new student object right here!
            basketWeaving.Roster.Add(new Student("Alicia Clark", 107, 2, 4.0));

            //Print info about course
            Console.WriteLine($"{basketWeaving.Name} ({basketWeaving.Id})");
            Console.WriteLine("Roster:");        //create a loop to walk through list of objects.

            foreach(Student student in basketWeaving.Roster)
            {
                Console.WriteLine(student.Name);
            }

         // Another new course
            Course history = new Course();
            history.Id = 205;
            history.Name = "Intro to World History";
            history.Length = 18;
            history.NumCredits = 6.0;
                    //generating a new student object below... gets passed into AddStudent method
            history.AddStudent(new Student("Clark", 109, 3, 4.0));
            history.AddStudent(new Student("Terri", 345, 1, 3.9));


            Student althea = new Student("Althea");
            Student isabelle = new Student("Isabelle");
            Student dwight = new Student("Dwight");

            Console.WriteLine($"Isabelle: {isabelle.StudentId}, GPA: {isabelle.Gpa}, # of Credits: {isabelle.NumberOfCredits}");
            Console.WriteLine($"Althea: {althea.StudentId}");
            Console.WriteLine($"Dwight: {dwight.StudentId}");

            isabelle.AddGrade(4, 3.0);
            isabelle.AddGrade(3, 4.0);
            isabelle.AddGrade(6, 3.5);

            Console.WriteLine($"Isabelle: {isabelle.StudentId}, GPA: {isabelle.Gpa}, # of Credits:  {isabelle.NumberOfCredits}");

            Teacher newTeach = new Teacher("Albert", "Einstein", "Physics");

            Console.WriteLine(isabelle);
            

        }
    }    
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Length { get; set; }
        public List<Student> Roster { get; set; }    //this is a list of student objects
        public double NumCredits { get; set; }

        public Course()
        {
        }

        //add a method called AddStudent so they get added to roster automatically.
        public void AddStudent(Student student)
        {
            if (this.Roster == null)
            {
                this.Roster = new List<Student>();    //if there's not already a roster this creates one.
            }
            this.Roster.Add(student);
        }
    }    
}

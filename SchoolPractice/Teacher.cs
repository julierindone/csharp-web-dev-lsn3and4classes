using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    public class Teacher
    {
        //create private static currentId
        private static int currentId = 500;

        //create private readonly id field
        private readonly int id;

        public int TeacherId
        {
            get { return id; }
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }
        public double YearsTeaching { get; set; }

        public Teacher()
        {
        }

        public Teacher(string firstName, string lastName, string subject, double yearsTeaching)
        {
            this.id = currentId++;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Subject = subject;
            this.YearsTeaching = yearsTeaching;
        }

        public Teacher(string _firstName, string _lastName, string _subject) : this(_firstName, _lastName, _subject, 0)  //THIS IS THAT OVERLOADED CONSTRUCTOR UGGGGH
        { }
    }
}

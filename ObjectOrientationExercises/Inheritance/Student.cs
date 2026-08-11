using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationClassExercise.Inheritance
{
    internal class Student : Person
    {
        public string StudentNumber { get; set; }
        public string NqfLevel { get; set; }
        public string Course { get; set; }
        public string Institution { get; set; }
        public int Year { get; set; }

        public Student(string studentNumber, string nqfLevel, string course, string institution, int year, string firstName, string surname, Gender gender, int age, Race race, bool alive) : base(firstName, surname, gender, age, race, alive)
        {
            StudentNumber = studentNumber;
            NqfLevel = nqfLevel;
            Course = course;
            Institution = institution;
            Year = year;
            FirstName = firstName;
            Surname = surname;
            Gender = gender;
            Age = age;
            Race = race;
            Alive = alive;
        }
    }
}

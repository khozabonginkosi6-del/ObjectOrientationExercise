using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationClassExercise.Inheritance
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public Race Race { get; set; }
        public bool Alive { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {Surname}";
            }
        }

        public Person(string firstName, string surname, Gender gender, int age, Race race, bool alive)
        {
            FirstName = firstName;
            Surname = surname;
            Gender = gender;
            Age = age;
            Race = race;
            Alive = alive;
        }

    }
}

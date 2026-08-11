using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationClassExercise.Inheritance
{
    internal class Employee : Person
    {
        public string EmployeeNumber { get; set; }
        public decimal Salary{ get; set; }
        public string Occupation { get; set; }
        public string Company { get; set; }
        public string TaxNumber { get; set; }
        public EmployementType EmployementType { get; set; }

        public Employee(string employeeNumber, decimal salary, string occupation, string company, string taxNumber, EmployementType employementType, string firstName, string surname, Gender gender, int age, Race race, bool alive) : base(firstName, surname, gender, age, race, alive)
        {
            EmployeeNumber = employeeNumber;
            Salary = salary;
            Occupation = occupation;
            Company = company;
            TaxNumber = taxNumber;
            EmployementType = employementType;
            FirstName = firstName;
            Gender = gender;
            Surname = surname;
            Gender = gender;
            Age = age;
            Race = race;
            Alive = alive;
        }
    }
}

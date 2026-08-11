using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationClassExercise.Inheritance
{
    internal class Pilot : Employee
    {
        public bool Licensed { get; set; }
        public double HoursFlown { get; set; }
        public FlyingType FlyingTpye { get; set; }

        public Pilot(bool licensed, double hoursFlown, FlyingType flyingType, string employeeNumber, decimal salary, string occupation, string company, string taxNumber, EmployementType employementType, string firstName, string surname, Gender gender, int age, Race race, bool alive) : base(employeeNumber, salary, occupation, company, taxNumber, employementType, firstName, surname, gender, age, race, alive)
        {
            Licensed = licensed;
            HoursFlown = hoursFlown;
            FlyingTpye = flyingType;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationClassExercise.Inheritance
{
    internal class InheritanceSample
    {
        public static void Run()
        {
            List<Person> people = new List<Person>();

            Person person = new Person("Alaska", "Johhanson", Gender.male, 24, Race.White, true);

            people.Add(person);

            Student student = new Student("5101917", "8", "Software Development", "CTU", 5, "Bobby", "Jones", Gender.male, 24, Race.African, false);

            people.Add(student);

            Employee employee = new Employee("5202927", 56000, "Programmer", "Bitcoin", "A1002", EmployementType.FullTime, "Nqobile", "Musk", Gender.male, 45, Race.Asian, true);

            people.Add(employee);

            Pilot pilot = new Pilot(true, 1200, FlyingType.Private, "21334", 78000, "Pilot", "FlySAFair", "231w", EmployementType.PartTime, "Simon", "Musk", Gender.male, 35, Race.Indian, false);

            people.Add(pilot);

            person = new Student("6576576", "7", "Computer Science", "UCT", 4, "Aron", "Nivan", Gender.female, 24, Race.White, true);

            people.Add(person);

            Console.WriteLine("People over 30 that are alive!!");
            foreach (Person singlePerson in people)
            {
                if (singlePerson.Alive && singlePerson.Age >= 30)
                {
                    Console.WriteLine($"Full Name: {singlePerson.FullName}");
                }
            }

            Console.WriteLine();

            Console.WriteLine("People that are full time employed!!");
            foreach (Person singlePerson in people)
            {
                if (singlePerson is Employee)
                {
                    Employee singleEmployee = singlePerson as Employee;

                    if (singleEmployee.EmployementType == EmployementType.PartTime || singleEmployee.EmployementType == EmployementType.FullTime)
                    {
                        Console.WriteLine($"Full Name: {singlePerson.FullName}");
                    }
                }
            }

            Console.WriteLine("People that are students and their student number");
            foreach(Person singlePerson in people)
            {
                if(singlePerson is Student)
                {
                    Student actualStudent = singlePerson as Student;

                    Console.WriteLine($"Full Name: {actualStudent.FullName} Student Number: {actualStudent.StudentNumber}");
                }
            }
        }
    }
}

using ObjectOrientationClassExercise.Inheritance;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationExercises.Interfaces
{
    internal class Wizard : GameCharacter
    {
        public Wizard(int health, int gold, string firstName, string surname, Gender gender, int age, Race race, bool alive) : base(health, gold, firstName, surname, gender, age, race, alive)
        {
        }
    }
}

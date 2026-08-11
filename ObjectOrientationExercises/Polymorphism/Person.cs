using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationClassExercise.Polymorphism
{
    internal class Person : Animal
    {
        public override void MakeNoise()
        {
            Console.WriteLine("screaming");
            PlaySound("male.wav");
        }
    }
}

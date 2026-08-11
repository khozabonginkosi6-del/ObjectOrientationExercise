using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationClassExercise.Polymorphism
{
    internal class Cow : Animal
    {
        public override void MakeNoise()
        {
            Console.WriteLine("Mooew");
           PlaySound("cow.mp3");

        }
    }
}

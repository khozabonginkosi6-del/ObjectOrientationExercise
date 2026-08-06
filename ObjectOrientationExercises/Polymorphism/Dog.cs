using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationClassExercise.Polymorphism
{
    internal class Dog : Animal
    {
        public override void MakeNoise()
        {
            Console.WriteLine("Woof");
            PlaySound("dog.mp3");
        }
    }
}

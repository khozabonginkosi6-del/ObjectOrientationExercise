using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationClassExercise.Polymorphism
{
    internal class Hyeana : Animal
    {
        public override void MakeNoise()
        {
            Console.WriteLine("HEHEHE");
            PlaySound("hyena.mp3");
        }
    }
}

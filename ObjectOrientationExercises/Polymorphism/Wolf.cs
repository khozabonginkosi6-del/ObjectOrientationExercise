using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationClassExercise.Polymorphism
{
    internal class Wolf : Dog
    {
        public override void MakeNoise()
        {
            Console.WriteLine("Awuuu");
            PlaySound("wolf.mp3");
        }
    }
}

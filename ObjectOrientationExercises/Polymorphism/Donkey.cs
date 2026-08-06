using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationClassExercise.Polymorphism
{
    internal class Donkey : Animal
    {
        public override void MakeNoise()
        {
            Console.WriteLine("YEEHAW");
            PlaySound("donkey.mp3");
        }
    }
}

using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationClassExercise.Polymorphism
{
    internal class Animal
    {
      
       
        protected void PlaySound(string filename)
        {
            string filenamePath = $"./Polymorphism/sounds/{filename}";

            using (var audioFile = new AudioFileReader(filenamePath))
            using (var outputDevice = new WaveOutEvent())
            {
                outputDevice.Init(audioFile);
                outputDevice.Play();

                while (outputDevice.PlaybackState == PlaybackState.Playing)
                {
                    Thread.Sleep(1000);
                }
            }
        }
        public virtual void MakeNoise()
        {
            Console.WriteLine("All animals can make a noise");
        }
    }
}

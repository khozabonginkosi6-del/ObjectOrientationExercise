using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace ObjectOrientationClassExercise.Polymorphism
{
    internal class PolymorphismSample
    {
        public static void Run()
        {
            List<Animal> zoo = new List<Animal>();

            Animal animal = new Dog();
            zoo.Add(animal);

            animal  = new Cow();
            zoo.Add(animal);

            animal = new Hyeana();
            zoo.Add(animal);

            animal = new Lion();
            zoo.Add(animal);

            animal = new Donkey();
            zoo.Add(animal);

            animal = new Wolf();
            zoo.Add(animal);

            animal = new Person();
            zoo.Add(animal);

            foreach (Animal cagedAnimal in zoo)
            {
                Console.Write($"{cagedAnimal.GetType().Name} -");
                cagedAnimal.MakeNoise();
            }
        }
    }
}

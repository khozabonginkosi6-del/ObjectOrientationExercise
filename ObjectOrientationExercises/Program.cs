using ObjectOrientationClassExercise.Polymorphism;
using ObjectOrientationExercises.Interfaces;
using ObjectOrientationClassExercise.Inheritance;
using ObjectOrientationExercises.Encapsulation;
using System.Numerics;


namespace ObjectOrientationExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EncapsulationSample.Run();

            //AbstractionSample.Run();

            //InheritanceSample.Run();

            PolymorphismSample.Run();

            InterfacesSample sample = new InterfacesSample();
            sample.Run();
        }
    }
}

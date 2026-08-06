using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationClassExercise.Abstraction
{
    internal class AbstractionSample
    {
        public static void Run()
        {
            List<Shape> toyBox = new List<Shape>();

            Shape toy = new Triangle(5, 10);

            toyBox.Add(toy);

            toy = new Square(8);

            toyBox.Add(toy);

            toy = new Rectangle(15, 8);

            toyBox.Add(toy);

            toy = new Circle(6);

            toyBox.Add(toy);

            toy = new Rhombus(20, 40);

            toyBox.Add(toy);

            toy = new FancyRhombus(new Triangle(10, 20), new Triangle(10, 20));

            toyBox.Add(toy);

            double totalArea = 0;

            foreach (Shape shape in toyBox)
            {
                double area = shape.GetArea();
                Console.WriteLine($"{shape.GetType().Name}" + $"  {area}");
                totalArea += area;
            }

            Console.WriteLine($"Toatal area: {totalArea}");
        }
            
    }
}

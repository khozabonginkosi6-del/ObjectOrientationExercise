using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationClassExercise.Abstraction
{
    internal class Rectangle : Shape
    {
        public double width;
        public double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double GetArea()
        {
            return width * height;
        }
    }
}

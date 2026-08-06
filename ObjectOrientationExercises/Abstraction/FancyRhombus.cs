using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationClassExercise.Abstraction
{
    internal class FancyRhombus : Shape
    {
        private Shape firstTriangle;
        private Shape secondTriangle;

        public FancyRhombus(Shape firstTriangle, Shape secondTriangle)
        {
            this.firstTriangle = firstTriangle;
            this.secondTriangle = secondTriangle;
        } 
        public override double GetArea()
        {
            return firstTriangle.GetArea() + secondTriangle.GetArea();
        }
    }
}

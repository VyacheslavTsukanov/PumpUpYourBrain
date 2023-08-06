using System;

namespace CalculateTheAreaTest
{
    public class Circle : Shape
    {
        double radius;
        public Circle(int radius)
        {
            this.radius = radius;
        }
        public override double Square() => Math.PI * radius * radius;
    }
}

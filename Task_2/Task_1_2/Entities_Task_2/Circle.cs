using System;

namespace Task_1_2.Entities_Task_2
{
    public class Circle : AbstractFigure
    {
        public double Radius { get; }

        public override double Area { get; }
        public override double Perimeter { get; }

        public Circle(Point center, double radius)
            : base(center)
        {
            Radius = radius;

            Perimeter = 2 * Math.PI * Radius;

            Area = Math.PI * Radius * Radius;
        }
    }
}

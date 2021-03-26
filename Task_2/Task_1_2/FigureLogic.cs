using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1_2.Entities_Task_2;

namespace Task_1_2
{
    public class FigureLogic
    {
        private double InputCoordinate(string coordinateOrient)
        {
            while (true)
            {
                Console.Write($"{coordinateOrient}: ");
                if (double.TryParse(Console.ReadLine(), out double coordinate))
                {
                    return coordinate;
                }
                else
                {
                    Console.WriteLine("Неверное значение! Введите координату снова.");
                }
            }
        }
        
        public Point CreatePoint()
        {
            Console.WriteLine("Введите координату X: ");
            var x = InputCoordinate("X");

            Console.WriteLine("Введите координату Y: ");
            var y = InputCoordinate("Y");

            return new Point(x, y);
        }

        public Line CreateLine()
        {
            Console.WriteLine("Введите первую точку");
            var point1 = CreatePoint();

            Console.WriteLine("Введите вторую точку");
            var point2 = CreatePoint();

            return new Line(point1, point2);
        }

        public Circle CreateCircle()
        {
            Console.WriteLine("Введите центр");
            var center = CreatePoint();

            Console.WriteLine("Введите радиус: ");
            var radius = CreateLine();

            var circle = new Circle(center, radius.Length);
            if (FigureValidator.IsValid(circle))
            {
                return circle;
            }
            return null;
        }

        public Ring CreateRing()
        {
            Console.WriteLine("Введите центр");
            var center = CreatePoint();

            Console.WriteLine("Введите радиус первой окружности: ");
            var radius1 = CreateLine();

            Console.WriteLine("Введите радиус второй окружности: ");
            var radius2 = CreateLine();

            //return new Ring(center, Math.Min(radius1.Length, radius2.Length), Math.Max(radius1.Length, radius2.Length));
            var ring = new Ring(center, Math.Min(radius1.Length, radius2.Length), Math.Max(radius1.Length, radius2.Length));
            if (FigureValidator.IsValid(ring))
            {
                return ring;
            }
            return null;
        }

       
    }
}

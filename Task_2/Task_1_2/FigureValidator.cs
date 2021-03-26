using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1_2.Entities_Task_2;

namespace Task_1_2
{
    public static class FigureValidator
    {
        public static bool IsValid(Line line)
        {
            if (line.StartPoint == line.EndPoint && line.StartPoint == line.EndPoint)
            {
                throw new Exception("Заданы две точки в одном месте!");
            }

            if (line.StartPoint == null || line.EndPoint == null)
            {
                throw new NullReferenceException("Задана точка значением null!");
            }

            return true;
        }

        public static bool IsValid(Circle circle)
        {
            if (circle.Radius <= 0)
            {
                throw new Exception("Радиус не может быть равен 0 или меньше!");
            }

            return true;
        }

        public static bool IsValid(Ring ring)
        {
            if (ring.InnerCircle.Radius == ring.OuterCircle.Radius && ring.InnerCircle.Center == ring.OuterCircle.Center)
            {
                throw new Exception("Внешний и внутренний круг заданы одинаково!");
            }

            return true;
        }
    }
}

namespace Round2
{
    public class Round
    {
        public double x { get; private set; }//координаты центра
        public double y { get; private set; }
        public double Radius { get; private set; }//радиус окружности
        public double Area;//площадь окружности

        public Round() { }

        //Конструктор по координатам и радиусу
        public Round(double x, double y, double r)
        {
            this.x = x;
            this.y = y;
            this.Radius = r;
        }
        //Конструктор по радиусу
        public Round(double r)
        {
            this.Radius = r;
        }
        public double ploshad()
        {
            double pi = 3.14;
            return Radius * Radius * pi;
        }
        //Индексатор
        public double this[int index]
        {
            get
            {
                if (index == 1)
                    return x;
                else
                    return y;
            }
            set
            {
                if (index == 1)
                    x = value;
                else
                    y = value;
            }
        }
        public static bool operator ==(Round c1, Round c2)
        {
            if (c1.ploshad() == c2.ploshad())
                return true;
            else
                return false;
        }
        public static bool operator !=(Round c1, Round c2)
        {
            if (c1.ploshad() != c2.ploshad())
                return true;
            else
                return false;
        }
        public static double operator *(Round c, double m)
        {
            return c.Radius * m;
        }
        public static double operator /(Round c, double d)
        {
            return c.Radius / d;
        }
        public override string ToString()
        {
            return $"x={x} y={y} r={Radius}";
        }
    }
}

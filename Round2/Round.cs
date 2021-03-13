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
        public double Ploshad()
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
        public static double operator *(Round c, int m)
        {
            c.Radius = c.Radius * m;
            return c.Radius;
        }
        public static double operator /(Round c, int d)
        {
            c.Radius = c.Radius / d;
            return c.Radius;
        }
        public override string ToString()
        {
            return "x = " + x + " y = " + y + " r = " + Radius;
        }
    }

}

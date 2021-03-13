using FluentValidation.Results;
using Round2.Logic;
using System;
using System.Collections.Generic;
using System.IO;

namespace Round2
{
    public class UiLogic
    {
        public void Run()
        {
            Console.WriteLine("Run");
            var listRounds = ReaderFile();
            var logicRound = new RoundLogic();
            var rounds = new List<Round>();

            Round tempRound;

            foreach (var item in listRounds)
            {
                tempRound = logicRound.Create(item[0], item[1],item[2], out IEnumerable<ValidationFailure> listError);
                if (tempRound != null)
                    rounds.Add(tempRound);

                foreach (var error in listError)
                {
                     Console.WriteLine($"{error.ErrorMessage} coord: x= {item[0]} y={item[1]} radius={item[2]}");
                }   
            }
            //Демонстрация

            Round c1 = rounds[0];
            Round c2 = rounds[1];
            Round c3 = rounds[2];
            Round c4 = rounds[3];

            Console.WriteLine("Окружность 1: " + c1.ToString());
            Console.WriteLine("Окружность 2: " + c2.ToString());
            Console.WriteLine("Окружность 3: " + c3.ToString());

            if (c1 == c2) Console.WriteLine("Окружности 1 и 2 равны");
            if (c2 == c3) Console.WriteLine("Окружности 2 и 3 равны");

            if (c1 != c2) Console.WriteLine("Окружности 1 и 2 не равны");
            if (c2 != c3) Console.WriteLine("Окружности 2 и 3 не равны");

            Console.WriteLine("Площадь 1 окружности: " + c1.Ploshad());
            Console.WriteLine("Площадь 2 окружности: " + c2.Ploshad());
            Console.WriteLine("Площадь 3 окружности: " + c3.Ploshad());

            Console.WriteLine("Установка координат 2 окружности. Теперь координаты x и y равны 3 и 4 соответственно ");
            c2[1] = 3;
            c2[2] = 4;
            Console.WriteLine("Окружность 2: " + c2.ToString());
            Console.WriteLine("Координаты 2 окружности: x = " + c2[1] + " y = " + c2[2]);

            Console.WriteLine("Увеличение радиуса окружности");
            Console.WriteLine("До увеличения радиуса окружности 3: " + c3.ToString());
            Console.WriteLine("Увеличение радиуса 3 окружности в 5 раз. Теперь радиус равен " + c3 * 5);
            Console.WriteLine("После увеличения радиуса окружности 3: " + c3.ToString());
            Console.WriteLine("Уменьшение радиуса окружности");
            Console.WriteLine("До уменьшения радиуса окружности 2: " + c2.ToString());
            Console.WriteLine("Уменьшение радиуса 2 окружности в 2 раза. Теперь радиус равен " + c2 / 2);
            Console.WriteLine("После уменьшения радиуса окружности 2: " + c2.ToString());

            Console.ReadKey();

        }

        private IEnumerable<IList<double>> ReaderFile()
        {
            var listData = new List<List<double>>();
            using (var file = new StreamReader("TextFile1.txt"))
            {
                try
                {
                    string[] lines;

                    while (!file.EndOfStream)
                    {
                        lines = file.ReadLine().Split(' ');
                        if (lines.Length == 3)
                        {
                            double.TryParse(lines[0], out double x);
                            double.TryParse(lines[1], out double y);
                            double.TryParse(lines[2], out double radius);

                            listData.Add(new List<double> { x, y, radius });
                        } 
                    }    
                }
                catch
                {
                    Console.WriteLine("Data error in the file");
                }
            }
            return listData;
        }
    }
}

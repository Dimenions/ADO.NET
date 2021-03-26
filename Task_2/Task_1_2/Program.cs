using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using Task_1_2.Entities_Task_2;

/*
 * Напишите класс, задающий круг с указанными координатами центра, радиусом, а также
 * свойствами, позволяющими узнать длину описанной окружности и площадь круга.
 * 
 * Кроме этого, создайте класс, описывающий кольцо, заданное координатами центра, внешним и
 * внутренним радиусами, а также свойствами, позволяющими узнать площадь кольца и суммарную
 * длину внешней и внутренней окружностей.
 * 
 * Подумайте над взаимосвязью этих сущностей, возможной иерархией. Задача – максимально
 * сократить повтор кода в рамках задания.
 * 
 * По аналогии опишите классы других фигур. На их основе реализуйте собственный графический
 * редактор, который взаимодействует с кольцами, окружностями, кругами, прямоугольниками,
 * квадратами, треугольниками и линиями.
 * 
 * Пользователю доступны следующие действия:
 * - добавить фигуру (предварительно введя её характеристики)
 * - вывести все фигуры на экран (вывести список фигур и их характеристик)
 * - очистить холст (удалить все фигуры)
 * 
 * Требование корректности характеристик фигур на каждом этапе неизменно, помните об этом!
 */


namespace Task_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentCommand = "";

            FigureLogic figureCreator = new FigureLogic();

            Ring currentRing = figureCreator.CreateRing();

            while (currentCommand != "0")
            {
                Console.Clear();
                Console.WriteLine(
                    @"Введите комманду : 
    1: Вычислить площадь кольца
    2: Вычислить суммарную длину внешней окружности
    3: Вычислить суммарную длину внутренней окружности
    0: Выход
");
                currentCommand = Console.ReadLine().Trim();
                switch (currentCommand)
                {
                    case "1":
                        Console.WriteLine($"Площадь кольца is: {currentRing.Area}");
                        break;
                    case "2":
                        Console.WriteLine($"Длина внешней окружности: {currentRing.OuterCircle.Perimeter}");
                        break;
                    case "3":
                        Console.WriteLine($"Длина внешней окружности: {currentRing.InnerCircle.Perimeter}");
                        break;
                    case "0":
                        currentCommand = "0";
                        break;
                }
                Console.ReadKey();
            }

            Console.ReadKey();
        }

    }
}

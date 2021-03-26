using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace Task_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime date = new DateTime(1945, 23, 20);
            DateTime date = new DateTime(1945, 2, 20);

            string compositDate = "";

            Console.WriteLine("Введите год:");
            compositDate += Console.ReadLine() + ".";

            Console.WriteLine("Введите месяц:");
            compositDate += Console.ReadLine() + ".";

            Console.WriteLine("Введите день:");
            compositDate += Console.ReadLine();

            DateTime otherDate;
            if(DateTime.TryParse(compositDate, out otherDate) == false)
            {
                Console.WriteLine("Неверная дата!");
                return;
            }

            User user = new User()
            {
                Name = "Jesus",
                Surname = "Christ",
                Patronymic = "Gospodovich",

                BirthDate = otherDate,
                Age = 33
            };

            Employee employee = new Employee()
            {
                Name = "JesusReborn",
                Surname = "God",
                Patronymic = "NewVersion",

                WorkingExp = 2021,
                Position = "№2",

                BirthDate = date,
                Age = 33
            };

            UserValidation validations = new UserValidation();

            var result = validations.Validate(user);

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}

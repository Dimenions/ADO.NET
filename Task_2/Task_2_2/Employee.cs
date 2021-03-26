using System;

namespace Task_2_2
{
    public class Employee : User
    {
        public int WorkingExp { get; set; }
        public string Position { get; set; }

        public Employee() : base()
        {
            WorkingExp = 0;
            Position = "";
        }

        public Employee(string name, string surname, string patronymic, DateTime birthDate, int age, int workingExp, string position)
            : base(name, surname, patronymic, birthDate, age)
        {
            WorkingExp = workingExp;
            Position = position;
        }

        public Employee(User user, int workingExp, string position) : base(user)
        {
            WorkingExp = workingExp;
            Position = position;
        }
    }
}

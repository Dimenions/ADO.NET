using System;

namespace Task_2_2
{
    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }

        public DateTime BirthDate { get; set; }

        public int Age { get; set; }
        
        public User()
        {
            Name = "";
            Surname = "";
            Patronymic = "";

            BirthDate = new DateTime();

            Age = 0;
        }

        public User(string name, string surname, string patronymic, DateTime birthDate, int age)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;

            BirthDate = birthDate;

            Age = age;
        }

        public User(User user) : this(user.Name, user.Surname, user.Patronymic, user.BirthDate, user.Age)
        {}
    }
}

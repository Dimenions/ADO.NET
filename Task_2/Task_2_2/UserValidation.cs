using FluentValidation;
using System.Text.RegularExpressions;
using System;
namespace Task_2_2
{
    public class UserValidation : AbstractValidator<User>
    {
        //[A-Z][a-z][а-я][А-Я]
        public UserValidation()
        {
            var regex = new Regex(@"[^A-Za-zа-яА-Я]");

            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Name).Matches(@"[^A-Za-zа-яА-Я]");
            RuleFor(x => x.Surname).NotEmpty();
            //RuleFor(x => x.Surname).Matches(@"[^A-Za-zа-яА-Я]").WithMessage("Введите корректно фамилию");
            RuleFor(x => x.Surname).Must(x => regex.Matches(x).Count == 0).WithMessage("!!!!");

            RuleFor(x => x.Patronymic).NotEmpty();
            RuleFor(x => x.Patronymic).Matches(@"[^A-Za-zа-яА-Я]");

            RuleFor(x => x.Age).NotEmpty();
            RuleFor(x => x.Age).GreaterThan(0);

            RuleFor(x => x.BirthDate).NotEmpty();
            //RuleFor(x => x.BirthDate).DatePublicationValid(1900);
            RuleFor(x => x.BirthDate).Must(birthDate => birthDate.Year >= 1900 && birthDate <= DateTime.Now).
                WithMessage(("Введите корректно дату"));

        }
    }
}

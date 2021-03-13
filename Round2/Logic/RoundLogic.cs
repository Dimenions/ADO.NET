using FluentValidation.Results;
using Round2.Interfaces;
using Round2.Validators;
using System.Collections.Generic;

namespace Round2.Logic
{
    public class RoundLogic : IRoundLogic
    {
        public Round Create(double x, double y, double radius, out IEnumerable<ValidationFailure> listError)
        {
            var validator = new RoundValidator();
            var tempRound = new Round(x, y, radius);

            var result = validator.Validate(tempRound);

            if (result.IsValid == false)
            {
                listError = result.Errors;
                return null;
            }

            listError = new List<ValidationFailure>();

            return tempRound;
        }
    }
}

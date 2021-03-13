using FluentValidation.Results;
using System.Collections.Generic;

namespace Round2.Interfaces
{
    public interface IRoundLogic
    {
        Round Create(double x, double y, double radius, out IEnumerable<ValidationFailure> listError);
    }
}

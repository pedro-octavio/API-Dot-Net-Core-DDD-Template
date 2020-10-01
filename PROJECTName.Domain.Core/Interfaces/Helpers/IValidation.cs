using FluentValidation.Results;
using System.Collections.Generic;

namespace PROJECTName.Domain.Core.Interfaces.Helpers
{
    public interface IValidation<T> where T : class
    {
        void Validate(T obj);
        string GenerateErrorMessage(IList<ValidationFailure> validationFailures);
    }
}

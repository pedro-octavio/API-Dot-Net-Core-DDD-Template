using FluentValidation;
using FluentValidation.Results;
using PROJECTName.Domain.Core.Interfaces.Helpers;
using System;
using System.Collections.Generic;

namespace PROJECTName.Domain.Helpers.Validator
{
    public class Validator<T> : IValidation<T> where T : class
    {
        private readonly IValidator<T> validator;

        public Validator(IValidator<T> validator) => this.validator = validator;

        public void Validate(T obj)
        {
            try
            {
                var validatorResult = validator.Validate(obj);

                if (!validatorResult.IsValid) throw new Exception(GenerateErrorMessage(validatorResult.Errors));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public string GenerateErrorMessage(IList<ValidationFailure> validationFailures)
        {
            try
            {
                var errorMessage = string.Empty;

                foreach (var error in validationFailures) errorMessage += $"{error.ErrorCode} - {error.ErrorMessage}\n";

                return errorMessage;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

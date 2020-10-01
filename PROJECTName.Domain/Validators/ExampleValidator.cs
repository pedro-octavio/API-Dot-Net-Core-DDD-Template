using FluentValidation;
using PROJECTName.Domain.Entities;

namespace PROJECTName.Domain.Validators
{
    public class ExampleValidator : AbstractValidator<Example>
    {
        public ExampleValidator()
        {
            RuleFor(example => example.Id)
                .NotNull().WithMessage("The Example.Id cannot be null.")
                .NotEmpty().WithMessage("The Example.Id cannot be empty.")
                .MaximumLength(10).WithMessage("The maximum length of Example.Property is 10 characters.");

            RuleFor(example => example.Property)
                .NotNull().WithMessage("The Example.Property cannot be null.")
                .NotEmpty().WithMessage("The Example.Property cannot be empty.")
                .MaximumLength(45).WithMessage("The maximum length of Example.Property is 45 characters.");
        }
    }
}

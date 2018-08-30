using FluentValidation;
using SatvaPartyRegister.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SatvaPartyRegister.Api.Gateway.Validators
{
    public class AddUpdateAccountantAdvocateModelValidator : AbstractValidator<AddUpdateAccountantAdvocateModel>
    {
        public AddUpdateAccountantAdvocateModelValidator()
        {
            RuleFor(w => w.Name)
                .NotEmpty()
                .WithMessage("Name is required")
                .MaximumLength(100)
                .WithMessage("Name cannot be more than 100 characters");

            RuleFor(w => w.MobileNumber)
                .MaximumLength(12)
                .WithMessage("Mobile number cannot be more 12 characters");

            RuleFor(w => w.EmailAddress)
               .MaximumLength(50)
               .WithMessage("Email address cannot be more 50 characters")
               .EmailAddress()
               .WithMessage("Email address is not valid");
        }
    }
}

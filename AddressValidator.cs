using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFluentValidtion
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
                RuleFor(c => c.Street).NotEmpty().WithMessage("Street is required");
            RuleFor(c => c.State).NotEmpty().WithMessage("State is required");
            RuleFor(c => c.StreetNumber).NotEmpty().WithMessage("StreetNumber is required");
        }
    }
}

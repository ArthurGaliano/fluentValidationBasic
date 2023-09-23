using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFluentValidtion
{
    public  class ClientValidation : AbstractValidator<Client>
    {
        public ClientValidation()
        {
            RuleSet("asd" ,() => {
                RuleFor(c => c.FirstName).NotEmpty().WithMessage("First Name is required");
                RuleFor(c => c.LastName).NotEmpty().WithMessage("Last Name is required");
                RuleFor(c => c.BirthDay).NotEmpty().WithMessage("BirthDay is required");
                RuleFor(c => c.Email).NotEmpty().WithMessage("Email is required");
            });

        
            RuleFor(c => c.Phone).NotEmpty().WithMessage("Phone is required");
            // llama al validador de Address
            RuleFor(c => c.Address).SetValidator(new AddressValidator());
         
            RuleFor(c => c.Country).NotEmpty().WithMessage("Country is required");
            // llama al validador de Order que seria una lista de Order
            RuleForEach(c => c.Orders).SetValidator(new OrderValidation());
        }
    }
}

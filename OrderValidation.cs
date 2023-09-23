using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace ConsoleFluentValidtion
{
    public class OrderValidation : AbstractValidator<Order>
    {
        public OrderValidation()
        {
                RuleFor(c => c.quantity).NotEmpty().WithMessage("Quantity is required");
                // tiene que ser mayor que cero
                RuleFor(c => c.quantity).GreaterThan(0).WithMessage("Quantity must be greater than zero000000000000000");
        }
    }
}

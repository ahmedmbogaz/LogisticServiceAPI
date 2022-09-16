using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(p => p.LastName).MinimumLength(2);
            RuleFor(p => p.LastName).MaximumLength(20);
            RuleFor(p => p.LastName).NotEmpty();

            RuleFor(p => p.FirstName).MinimumLength(2);
            RuleFor(p => p.FirstName).MaximumLength(20);
            RuleFor(p => p.FirstName).NotEmpty();

            RuleFor(p => p.AddressId).NotEmpty();

        }
    }
}

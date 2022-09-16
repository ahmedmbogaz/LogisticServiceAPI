using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(p => p.City).MinimumLength(2);
            RuleFor(p => p.City).MaximumLength(20);
            RuleFor(p => p.City).NotEmpty();
        }
    }
}

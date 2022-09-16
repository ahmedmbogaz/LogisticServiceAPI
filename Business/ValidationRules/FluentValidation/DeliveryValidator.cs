using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class DeliveryValidator : AbstractValidator<Delivery>
    {
        public DeliveryValidator()
        {
            RuleFor(p => p.DeliveredPersonalName).MinimumLength(2);
            RuleFor(p => p.DeliveredPersonalName).MaximumLength(20);
            RuleFor(p => p.DeliveredPersonalName).NotEmpty();

            RuleFor(p => p.AddressId).NotEmpty();

            RuleFor(p => p.NumberPlate).NotEmpty();
        }
    }
}

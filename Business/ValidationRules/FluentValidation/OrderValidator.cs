using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class OrderValidator : AbstractValidator<Order>
    {
        public OrderValidator()
        {
            RuleFor(c => c.PhoneNumber).MinimumLength(10);
            RuleFor(c => c.PhoneNumber).MaximumLength(11);
            RuleFor(c => c.PhoneNumber).NotEmpty();

            RuleFor(c => c.AddressId).NotEmpty();

            RuleFor(c => c.Status).NotEmpty();

            RuleFor(c => c.ProductId).NotEmpty();

            RuleFor(c => c.OrderTime).NotEmpty();

            RuleFor(c => c.ReceivedCustomerName).NotEmpty();
            RuleFor(c => c.ReceivedCustomerName).MinimumLength(2);
            RuleFor(c => c.ReceivedCustomerName).MaximumLength(500);
        }
    }
}

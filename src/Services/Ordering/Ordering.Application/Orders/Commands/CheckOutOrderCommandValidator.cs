using FluentValidation;
using Ordering.Application.Orders.Commands.CheckOutOrder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Application.Orders.Commands
{
    public class CheckOutOrderCommandValidator:AbstractValidator<CheckOutOrderCommand>
    {
        public CheckOutOrderCommandValidator()
        {
            //RuleFor(x => x.Name).NotEmpty();

            //RuleFor(x => x.ScheduledOn).NotEmpty();
        }
    }
}

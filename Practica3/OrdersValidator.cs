using FluentValidation;
using Practica3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    public class OrdersValidator : AbstractValidator<Orders>
    {
        public OrdersValidator() 
        {
            RuleFor(a => a.CustomerId).NotEmpty().MaximumLength(5);
            RuleFor(a => a.EmployeeId).NotEmpty();
            RuleFor(a => a.ShipVia).NotEmpty();
            RuleFor(a => a.Freight).NotEmpty();
            RuleFor(a => a.ShipName).NotEmpty().MaximumLength(40);
            RuleFor(a => a.ShipCity).NotEmpty().MaximumLength(15);
            RuleFor(a => a.ShipCountry).NotEmpty().MaximumLength(15);
        }
    }
}

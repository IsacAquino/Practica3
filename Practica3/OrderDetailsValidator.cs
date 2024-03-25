using FluentValidation;
using Practica3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    public class OrderDetailsValidator : AbstractValidator<OrderDetails>
    {
        public OrderDetailsValidator()
        {
            
            RuleFor(a => a.ProductId).NotEmpty();
            RuleFor(a => a.UnitPrice).NotEmpty();
            RuleFor(a => a.Quantity).NotEmpty();
        }
    }
        
    
}

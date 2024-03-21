using FluentValidation;
using Practica3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    public class ProductsValidator : AbstractValidator<Products>
    {
        public ProductsValidator() 
        { 
            RuleFor(a => a.ProductName).NotEmpty().MaximumLength(40);
            RuleFor(a => a.SupplierId).NotEmpty();
            RuleFor(a => a.CategoryId).NotEmpty();
            RuleFor(a => a.QuantityPerUnit).NotEmpty().MaximumLength(20);
            RuleFor(a => a.UnitPrice).NotEmpty();
            RuleFor(a => a.UnitsInStock).NotEmpty();
            RuleFor(a => a.UnitsOnOrder).NotEmpty();
            RuleFor(a => a.ReorderLevel).NotEmpty();
        }
    }
}

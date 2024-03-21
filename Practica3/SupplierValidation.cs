using FluentValidation;
using Practica3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    public class SupplierValidation:AbstractValidator<Suppliers>
    {
        public SupplierValidation() 
        {
            RuleFor(a => a.CompanyName).NotEmpty().MaximumLength(40);
            RuleFor(a => a.ContactName).NotEmpty().MaximumLength(30);
            RuleFor(a => a.ContactTitle).NotEmpty().MaximumLength(30);
            RuleFor(a => a.Address).NotEmpty().MaximumLength(60);
            RuleFor(a => a.City).NotEmpty().MaximumLength(15);
            //RuleFor(a => a.Region).NotEmpty().MaximumLength(15);
            RuleFor(a => a.PostalCode).NotEmpty().MaximumLength(10);
            RuleFor(a => a.Country).NotEmpty().MaximumLength(15);
            RuleFor(a => a.Phone).NotEmpty().MaximumLength(24);
            //RuleFor(a => a.Fax).NotEmpty().MaximumLength(24);
            //RuleFor(a => a.HomePage).NotEmpty();
        }
    }
}

using FluentValidation;
using Practica3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    public class CategoriesValidator : AbstractValidator<Categories>
    {
        public CategoriesValidator() 
        {
            RuleFor(a => a.CategoryName).NotEmpty().MaximumLength(15);
            RuleFor(a => a.Description).NotEmpty().MaximumLength(500);
        }
    }
}

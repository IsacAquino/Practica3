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
            RuleFor(a => a.ProductName).NotEmpty().MaximumLength(40).WithMessage("El nombre del producto es obligatorio."); ; 
            RuleFor(a => a.QuantityPerUnit).NotEmpty().MaximumLength(20).WithMessage("La cantidad por unidad es obligatoria."); ;
            RuleFor(a => a.UnitPrice).GreaterThan(0).WithMessage("El precio unitario debe ser mayor que cero.");
            RuleFor(product => product.UnitsInStock).GreaterThanOrEqualTo((short)0).WithMessage("Las unidades en stock deben ser mayores o iguales a cero.");
            RuleFor(product => product.UnitsOnOrder).GreaterThanOrEqualTo((short)0).WithMessage("Las unidades en orden deben ser mayores o iguales a cero.");
            RuleFor(product => product.ReorderLevel).GreaterThanOrEqualTo((short)0).WithMessage("El nivel de reorden debe ser mayor o igual a cero.");
        }
    }
}

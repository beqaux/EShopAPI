using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShopAPI.Application.ViewModels.Products;
using FluentValidation;

namespace EShopAPI.Application.Validators
{
    public class CreateProductValidator : AbstractValidator<VM_Create_Product>
    {
        public CreateProductValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .NotNull().WithMessage("Please fill the blanks.")
                .MaximumLength(150)
                .MinimumLength(2).WithMessage("Product name can be from 2 to 150 characters");

            RuleFor(s => s.Stock)
                .NotEmpty()
                .NotNull().WithMessage("Please fill the blanks.")
                .Must(s => s >= 0).WithMessage("Stock can't be lower than 0");

            RuleFor(p => p.Stock)
                .NotEmpty()
                .NotNull().WithMessage("Please fill the blanks.")
                .Must(s => s >= 0).WithMessage("Price can't be lower than 0");
        }
    }
}

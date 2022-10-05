using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class BrandValidator : AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            RuleFor(b => b.BrandName).NotEmpty().WithMessage("Marka ismi boş olamaz!");
            RuleFor(b => b.BrandName).MinimumLength(2).WithMessage("Marka ismi 2'den az olamaz!");
        }
    }
}

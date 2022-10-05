using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.CarName).NotEmpty().WithMessage("Araç ismi boş olamaz!");
            RuleFor(c => c.CarName).MinimumLength(2).WithMessage("Araç ismi 2'den az olamaz!");
            RuleFor(c => c.Description).NotEmpty().WithMessage("Açıklama boş geçilemez");
            RuleFor(c => c.ModelYear).NotEmpty().WithMessage("Yıl bilgisi boş geçilemez");
        }
    }
}

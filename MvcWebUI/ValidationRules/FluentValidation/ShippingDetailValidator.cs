using FluentValidation;
using MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWebUI.ValidationRules.FluentValidation
{
    public class ShippingDetailValidator : AbstractValidator<ShippingDetail>
    {
        public ShippingDetailValidator()
        {
            RuleFor(expression: s => s.FirstName).NotEmpty().WithMessage("İsim zorunlu");
            RuleFor(expression: s => s.FirstName).MinimumLength(2);
            RuleFor(expression: s => s.LastName).NotEmpty();
            RuleFor(expression: s => s.Address).NotEmpty();
            RuleFor(expression: s => s.Email).EmailAddress();
            RuleFor(expression: s => s.City).NotEmpty().When(predicate: s => s.Age < 18);//yası 18 den kucukse ozman sehırı gırsın
            //RuleFor(expression: s => s.FirstName).Must(StartWithA);//must kendi kuralını yazmak ıcın kullanılır
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}

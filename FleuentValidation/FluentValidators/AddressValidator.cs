using FleuentValidation.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FleuentValidation.FluentValidators
{
    public class AddressValidator:AbstractValidator<Address>
    {
        public string NotEmptyMessagge { get; } = "{PropertyName} alanı boş olamaz";
        public AddressValidator()
        {
            RuleFor(x => x.Content).NotEmpty().WithMessage(NotEmptyMessagge);
            RuleFor(x => x.Province).NotEmpty().WithMessage(NotEmptyMessagge);
            RuleFor(x => x.PostCode).NotEmpty().WithMessage(NotEmptyMessagge);
        }
    }
}

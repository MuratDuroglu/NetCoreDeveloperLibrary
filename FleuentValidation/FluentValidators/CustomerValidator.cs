using FleuentValidation.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FleuentValidation.FluentValidators
{
    public class CustomerValidator:AbstractValidator<Customer>
    {

        public string NotEmptyMessagge { get; } = "{PropertyName} alanı boş olamaz";
        public CustomerValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name alanı boş olamaz");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email alanı boş olamaz").EmailAddress().WithMessage("Email alanı doğru format olmalıdır");
            RuleFor(x => x.Age).NotEmpty().WithMessage("Age alanı boş olamaz").InclusiveBetween(18, 60).WithMessage("Age alanı 18 ile 60 arası olmalıdır");
           // RuleFor(x => x.BirthDay).NotEmpty().WithMessage(NotEmptyMessagge).Must(x => { return DateTime.Now.AddYears(-18) >= x; }).WithMessage("Yaşınız 18 yaşından büyük olmalıdır");
             
        }
    }
}

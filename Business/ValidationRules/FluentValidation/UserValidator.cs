using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.FirstName).NotEmpty().WithMessage("FirstName alanı boş olamaz");
            RuleFor(u => u.LastName).NotEmpty().WithMessage("LastName alanı boş olamaz");
            RuleFor(u => u.Email).NotEmpty().WithMessage("Email alanı boş olamaz");
            RuleFor(u => u.Email).EmailAddress().WithMessage("Email alanı geçerli değil");
            RuleFor(u => u.FirstName).MinimumLength(3).WithMessage("FirstName alanı en az 3 karakter olmalıdır");
            RuleFor(u => u.LastName).MinimumLength(3).WithMessage("LastName alanı en az 3 karakter olmalıdır");
            RuleFor(u => u.Email).MinimumLength(3).WithMessage("Email alanı en az 3 karakter olmalıdır");
        }
    }
}

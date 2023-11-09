using FluentValidation;
using PlatePass.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatePass.Business.Validation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(user => user.EmailAdres).NotEmpty().EmailAddress();
            RuleFor(user => user.UserName).NotEmpty();
            RuleFor(user => user.UserSurname).NotEmpty();
        }

    }
}

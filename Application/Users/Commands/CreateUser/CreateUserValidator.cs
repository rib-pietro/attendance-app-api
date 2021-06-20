using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using AttendanceApp.Domain.Enums;

namespace AttendanceApp.Application.Users.Commands.CreateUser
{
    public class CreateUserInputValidator : AbstractValidator<CreateUserInput>
    {
        public CreateUserInputValidator()
        {
            RuleFor(v => v.Name)
                .MaximumLength(200)
                .NotEmpty()
                ;

            RuleFor(v => v.Email)
                .EmailAddress()
                .NotEmpty()
                ;

            RuleFor(v => v.Password)
                .MinimumLength(6)
                .Must(BeAValidPassword)
                .NotEmpty()
                ;

            RuleFor(v => v.CompanyId)
                .GreaterThan(0)
                .NotEmpty()
                ;

            RuleFor(v => v.Role)
                .IsInEnum()
                ;

        }

        private bool BeAValidPassword(string password)
        {
            // TO-DO: one special character, one letter and one number
            return true;
        }
    }
}

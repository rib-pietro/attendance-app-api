using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using AttendanceApp.Domain.Enums;

namespace AttendanceApp.Application.Users.Commands.CreateUser
{
    public class CreateUserInput : IRequest<int>
    {
        public string Name { get; set; }
        public Role Role { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int CompanyId { get; set; }
    }
}

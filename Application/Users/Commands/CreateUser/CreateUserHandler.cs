using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using MediatR;
using AttendanceApp.Application.Common.Interfaces;
using AttendanceApp.Domain.Entities;
using AttendanceApp.Domain.Enums;

namespace AttendanceApp.Application.Users.Commands.CreateUser
{
    public class CreateUserHandler : IRequestHandler<CreateUserInput, int>
    {
        private readonly IApplicationDbContext _context;

        public CreateUserHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateUserInput input, CancellationToken cancellationToken)
        {
            var entity = new User
            {
                Name = input.Name,
                CompanyId = input.CompanyId,
                Role = (Role)input.Role,
                Email = input.Email,
                Password = input.Password
            };

            _context.Users.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return entity.Id;
        }
    }
}

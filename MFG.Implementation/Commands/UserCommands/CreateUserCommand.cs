using AutoMapper;
using FluentValidation;
using MFG.Application.Commands.UserCommands;
using MFG.Application.DataTransfer;
using MFG.DataAccess;
using MFG.Domain;
using MFG.Implementation.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Implementation.Commands.UserCommands
{
    public class CreateUserCommand : ICreateUserCommand
    {
        private readonly MFGContext _context;
        private readonly IMapper _mapper;
        private readonly UserValidator _validator;

        public CreateUserCommand(MFGContext context, IMapper mapper, UserValidator validator)
        {
            _context = context;
            _mapper = mapper;
            _validator = validator;
        }

        public int Id => 1111;

        public string Name => "Create User";

        public void Execute(UserDto request)
        {
            _validator.ValidateAndThrow(request);

            var user = _mapper.Map<User>(request);

            user.RoleID = 3;

            _context.Users.Add(user);

            _context.SaveChanges();
        }
    }
}
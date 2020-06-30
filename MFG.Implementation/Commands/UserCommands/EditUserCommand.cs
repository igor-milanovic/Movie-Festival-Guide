using AutoMapper;
using FluentValidation;
using MFG.Application.Commands.UserCommands;
using MFG.Application.DataTransfer;
using MFG.Application.Exceptions;
using MFG.DataAccess;
using MFG.Domain;
using MFG.Implementation.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Implementation.Commands.UserCommands
{
    public class EditUserCommand : IEditUserCommand
    {
        private readonly MFGContext _context;
        private readonly IMapper _mapper;
        private readonly UserValidator _validator;

        public EditUserCommand(MFGContext context, IMapper mapper, UserValidator validator)
        {
            _context = context;
            _mapper = mapper;
            _validator = validator;
        }

        public int Id => 1113;

        public string Name => "Edit User";

        public void Execute(UserDto request)
        {
            var user = _context.Users.Find(request.Id);

            if (user == null)
            {
                throw new EntityNotFoundException(request.Id, typeof(User));
            }

            _validator.ValidateAndThrow(request);

            request.RoleID = user.RoleID;

            _mapper.Map(request, user);

            _context.SaveChanges();
        }
    }
}
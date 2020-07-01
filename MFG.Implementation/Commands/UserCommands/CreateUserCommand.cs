using AutoMapper;
using FluentValidation;
using MFG.Application.Commands.UserCommands;
using MFG.Application.DataTransfer;
using MFG.Application.Email;
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
        private readonly UserCreateDtoValidator _validator;
        private readonly IEmailSender _emailSender;

        public CreateUserCommand(MFGContext context, IMapper mapper, UserCreateDtoValidator validator, IEmailSender emailSender)
        {
            _context = context;
            _mapper = mapper;
            _validator = validator;
            _emailSender = emailSender;
        }

        public int Id => 1111;

        public string Name => "Create User";

        public void Execute(UserCreateDto request)
        {
            _validator.ValidateAndThrow(request);

            var user = _mapper.Map<User>(request);

            user.RoleID = 1;

            _context.Users.Add(user);

            _context.SaveChanges();

            _emailSender.Send(new SendEmailDto
            {
                Body = "<h1>Successfull registration!</h1>",
                SendTo = request.Email,
                Subject = "Registration"
            });
        }
    }
}
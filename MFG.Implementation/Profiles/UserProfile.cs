using AutoMapper;
using MFG.Application.DataTransfer;
using MFG.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Implementation.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();

            CreateMap<User, UserQueryDto>();
            CreateMap<UserQueryDto, User>();
        }
    }
}
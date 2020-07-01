using AutoMapper;
using MFG.Application.DataTransfer;
using MFG.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Implementation.Profiles
{
    public class DirectorProfile : Profile
    {
        public DirectorProfile()
        {
            CreateMap<Director, DirectorDto>();
            CreateMap<DirectorDto, Director>();

            CreateMap<Director, DirectorCreateDto>();
            CreateMap<DirectorCreateDto, Director>();
        }
    }
}
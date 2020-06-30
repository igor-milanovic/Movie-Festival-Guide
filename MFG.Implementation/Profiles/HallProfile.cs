using AutoMapper;
using MFG.Application.DataTransfer;
using MFG.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Implementation.Profiles
{
    public class HallProfile : Profile
    {
        public HallProfile()
        {
            CreateMap<Hall, HallDto>();
            CreateMap<HallDto, Hall>();
        }
    }
}
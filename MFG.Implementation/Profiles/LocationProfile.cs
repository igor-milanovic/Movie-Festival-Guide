using AutoMapper;
using MFG.Application.DataTransfer;
using MFG.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Implementation.Profiles
{
    public class LocationProfile : Profile
    {
        public LocationProfile()
        {
            CreateMap<Location, LocationDto>();
            CreateMap<LocationDto, Location>();

            CreateMap<Location, LocationQueryDto>();
            CreateMap<LocationQueryDto, Location>();
        }
    }
}
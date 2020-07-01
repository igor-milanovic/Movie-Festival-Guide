using AutoMapper;
using MFG.Application.DataTransfer;
using MFG.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Implementation.Profiles
{
    public class PlaceProfile : Profile
    {
        public PlaceProfile()
        {
            CreateMap<Place, PlaceDto>();
            CreateMap<PlaceDto, Place>();

            CreateMap<Place, PlaceCreateDto>();
            CreateMap<PlaceCreateDto, Place>();
        }
    }
}
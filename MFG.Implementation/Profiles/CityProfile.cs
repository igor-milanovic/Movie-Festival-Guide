using AutoMapper;
using MFG.Application.DataTransfer;
using MFG.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Implementation.Profiles
{
    internal class CityProfile : Profile
    {
        public CityProfile()
        {
            CreateMap<City, CityDto>();
            CreateMap<CityDto, City>();

            CreateMap<City, CityCreateDto>();
            CreateMap<CityCreateDto, City>();

            CreateMap<City, EditCityDto>();
            CreateMap<EditCityDto, City>();

            CreateMap<City, CityQueryDto>();
            CreateMap<CityQueryDto, City>();
        }
    }
}
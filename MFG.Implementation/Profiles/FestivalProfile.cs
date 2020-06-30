using AutoMapper;
using MFG.Application.DataTransfer;
using MFG.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Implementation.Profiles
{
    public class FestivalProfile : Profile
    {
        public FestivalProfile()
        {
            CreateMap<Festival, FestivalDto>();
            CreateMap<FestivalDto, Festival>();

            CreateMap<Festival, EditFestivalDto>();
            CreateMap<EditFestivalDto, Festival>();

            CreateMap<Festival, FestivalQueryDto>();
            CreateMap<FestivalQueryDto, Festival>();
        }
    }
}
using AutoMapper;
using MFG.Application.DataTransfer;
using MFG.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Implementation.Profiles
{
    public class ProjectionProfile : Profile
    {
        public ProjectionProfile()
        {
            CreateMap<Projection, ProjectionDto>();
            CreateMap<ProjectionDto, Projection>();

            CreateMap<Projection, ProjectionQueryDto>();
            CreateMap<ProjectionQueryDto, Projection>();

            CreateMap<Projection, ProjectionCreateDto>();
            CreateMap<ProjectionCreateDto, Projection>();
        }
    }
}
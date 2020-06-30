using AutoMapper;
using MFG.Application.DataTransfer;
using MFG.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Implementation.Profiles
{
    public class MovieProfile : Profile
    {
        public MovieProfile()
        {
            CreateMap<Movie, MovieDto>();
            CreateMap<MovieDto, Movie>();

            CreateMap<Movie, MovieQueryDto>();
            CreateMap<MovieQueryDto, Movie>();
        }
    }
}
using AutoMapper;
using MFG.Application.DataTransfer;
using MFG.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MFG.Implementation.Profiles
{
    public class MovieProfile : Profile
    {
        public MovieProfile()
        {
            CreateMap<Movie, MovieDto>()
                .ForMember(x => x.Directors, opt => opt.MapFrom(x => x.MovieDirectors.Select(x => x.DirectorID).ToList()));
            CreateMap<MovieDto, Movie>();

            CreateMap<Movie, MovieCreateDto>();
            CreateMap<MovieCreateDto, Movie>();

            CreateMap<Movie, MovieQueryDto>();
            CreateMap<MovieQueryDto, Movie>();
        }
    }
}
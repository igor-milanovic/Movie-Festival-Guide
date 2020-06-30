using AutoMapper;
using MFG.Application.DataTransfer;
using MFG.Application.Queries;
using MFG.Application.Searches;
using MFG.DataAccess;
using MFG.Domain;
using MFG.Implementation.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MFG.Implementation.Queries
{
    public class GetFestivalsQuery : IGetFestivalsQuery
    {
        public readonly MFGContext _context;
        public readonly IMapper _mapper;

        public GetFestivalsQuery(MFGContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public int Id => 231;

        public string Name => "Festival search";

        public PagedResponse<FestivalQueryDto> Execute(FestivalSearch search)
        {
            var query = _context.Festivals.Include(x => x.Place).AsQueryable();

            if (!string.IsNullOrEmpty(search.Name) && !string.IsNullOrWhiteSpace(search.Name))
            {
                query = query.Where(x => x.Name.ToLower().Contains(search.Name.ToLower()));
            }

            if (search.PlaceID is int)
            {
                query = query.Where(x => x.PlaceID == search.PlaceID);
            }

            return query.Paged<FestivalQueryDto, Festival>(search, _mapper);
        }
    }
}
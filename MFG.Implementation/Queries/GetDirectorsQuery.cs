using AutoMapper;
using MFG.Application.DataTransfer;
using MFG.Application.Queries;
using MFG.Application.Searches;
using MFG.DataAccess;
using MFG.Domain;
using MFG.Implementation.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MFG.Implementation.Queries
{
    public class GetDirectorsQuery : IGetDirectorsQuery
    {
        public readonly MFGContext _context;
        public readonly IMapper _mapper;

        public GetDirectorsQuery(MFGContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public int Id => 221;

        public string Name => "Director search";

        public PagedResponse<DirectorDto> Execute(DirectorSearch search)
        {
            var query = _context.Directors.AsQueryable();

            if (!string.IsNullOrEmpty(search.FirstName) && !string.IsNullOrWhiteSpace(search.FirstName))
            {
                query = query.Where(x => x.FirstName.ToLower().Contains(search.FirstName.ToLower()));
            }

            if (!string.IsNullOrEmpty(search.LastName) && !string.IsNullOrWhiteSpace(search.LastName))
            {
                query = query.Where(x => x.LastName.ToLower().Contains(search.LastName.ToLower()));
            }

            return query.Paged<DirectorDto, Director>(search, _mapper);
        }
    }
}
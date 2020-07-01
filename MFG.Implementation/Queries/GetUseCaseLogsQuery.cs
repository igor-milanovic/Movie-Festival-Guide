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
    public class GetUseCaseLogsQuery : IGetUseCaseLogsQuery
    {
        private readonly MFGContext _context;
        private readonly IMapper _mapper;

        public GetUseCaseLogsQuery(MFGContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public int Id => 2121;

        public string Name => "UseCaseLogs search";

        public PagedResponse<UseCaseLogDto> Execute(UseCaseLogSearch search)
        {
            var query = _context.UseCaseLogs.AsQueryable();

            if (!string.IsNullOrEmpty(search.UseCaseName) || !string.IsNullOrWhiteSpace(search.UseCaseName))
            {
                query = query.Where(x => x.UseCaseName.ToLower().Contains(search.UseCaseName.ToLower()));
            }

            if (!string.IsNullOrEmpty(search.Actor) || !string.IsNullOrWhiteSpace(search.Actor))
            {
                query = query.Where(x => x.Actor.ToLower().Contains(search.Actor.ToLower()));
            }

            if (search.BeforeDate != null)
            {
                query = query.Where(x => x.Date < search.BeforeDate);
            }

            if (search.AfterDate != null)
            {
                query = query.Where(x => x.Date > search.AfterDate);
            }

            return query.Paged<UseCaseLogDto, UseCaseLog>(search, _mapper);
        }
    }
}
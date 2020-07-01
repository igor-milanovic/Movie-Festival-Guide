using AutoMapper;
using MFG.Application.DataTransfer;
using MFG.Application.Queries;
using MFG.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Implementation.Queries
{
    public class GetProjectionQuery : IGetProjectionQuery
    {
        private readonly MFGContext _context;
        private readonly IMapper _mapper;

        public GetProjectionQuery(MFGContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public int Id => 282;

        public string Name => "Projections search by id";

        public ProjectionDto Execute(int search)
        {
            var query = _context.Projections.Find(search);
            return _mapper.Map<ProjectionDto>(query);
        }
    }
}
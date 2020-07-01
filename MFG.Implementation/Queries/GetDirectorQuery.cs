using AutoMapper;
using MFG.Application.DataTransfer;
using MFG.Application.Queries;
using MFG.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Implementation.Queries
{
    public class GetDirectorQuery : IGetDirectorQuery
    {
        public readonly MFGContext _context;
        public readonly IMapper _mapper;

        public GetDirectorQuery(MFGContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public int Id => 222;

        public string Name => "Director search by id";

        public DirectorDto Execute(int search)
        {
            var query = _context.Directors.Find(search);

            return _mapper.Map<DirectorDto>(query);
        }
    }
}
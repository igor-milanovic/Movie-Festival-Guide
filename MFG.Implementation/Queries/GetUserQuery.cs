using AutoMapper;
using MFG.Application.DataTransfer;
using MFG.Application.Queries;
using MFG.DataAccess;
using MFG.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Implementation.Queries
{
    public class GetUserQuery : IGetUserQuery
    {
        private readonly MFGContext _context;
        private readonly IMapper _mapper;

        public GetUserQuery(MFGContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public int Id => 2112;

        public string Name => "Users search by id";

        public UserQueryDto Execute(int search)
        {
            var _ = _context.Users.Find(search);

            return _mapper.Map<UserQueryDto>(_);
        }
    }
}
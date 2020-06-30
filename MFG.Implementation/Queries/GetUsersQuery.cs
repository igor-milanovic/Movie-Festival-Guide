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
    public class GetUsersQuery : IGetUsersQuery
    {
        private readonly MFGContext _context;
        private readonly IMapper _mapper;

        public GetUsersQuery(MFGContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public int Id => 2111;

        public string Name => "Users search";

        public PagedResponse<UserQueryDto> Execute(UserSearch search)
        {
            var query = _context.Users.AsQueryable();

            if (!string.IsNullOrEmpty(search.FirstName) || !string.IsNullOrWhiteSpace(search.FirstName))
            {
                query = query.Where(x => x.FirstName.ToLower().Contains(search.FirstName.ToLower()));
            }

            if (!string.IsNullOrEmpty(search.LastName) || !string.IsNullOrWhiteSpace(search.LastName))
            {
                query = query.Where(x => x.LastName.ToLower().Contains(search.LastName.ToLower()));
            }

            if (!string.IsNullOrEmpty(search.Username) || !string.IsNullOrWhiteSpace(search.Username))
            {
                query = query.Where(x => x.Username.ToLower().Contains(search.Username.ToLower()));
            }

            if (!string.IsNullOrEmpty(search.Email) || !string.IsNullOrWhiteSpace(search.Email))
            {
                query = query.Where(x => x.Email.ToLower().Contains(search.Email.ToLower()));
            }

            if (search.RoleID is int)
            {
                query = query.Where(x => x.RoleID == search.RoleID);
            }
            return query.Paged<UserQueryDto, User>(search, _mapper);
        }
    }
}
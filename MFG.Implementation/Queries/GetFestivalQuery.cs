using AutoMapper;
using MFG.Application.DataTransfer;
using MFG.Application.Queries;
using MFG.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MFG.Implementation.Queries
{
    public class GetFestivalQuery : IGetFestivalQuery
    {
        public readonly MFGContext _context;
        public readonly IMapper _mapper;

        public GetFestivalQuery(MFGContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public int Id => 232;

        public string Name => "Festival search";

        public FestivalQueryDto Execute(int search)
        {
            var query = _context.Festivals.Find(search);

            return _mapper.Map<FestivalQueryDto>(query);
        }
    }
}
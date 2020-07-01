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
    public class GetCityQuery : IGetCityQuery
    {
        private readonly MFGContext _context;
        private readonly IMapper _mapper;

        public GetCityQuery(MFGContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public int Id => 212;

        public string Name => "City search by ID";

        public CityQueryDto Execute(int search)
        {
            var city = _context.Cities.Find(search);

            return _mapper.Map<CityQueryDto>(city);
        }
    }
}
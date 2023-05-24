using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using ExCurrency.Application.Common.Interfaces;
using ExCurrency.Application.Common.Mappings;
using ExCurrency.Application.Common.Models;
using ExCurrency.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ExCurrency.Application.CurrencyItems.Queries.GetCurrencies;
public class GetCurrenciesWithPaginationQuery : IRequest<PaginatedList<CurrenciesDTO>>
{
    public int PageNumber { get; init; } = 1;
    public int PageSize { get; init; } = 10;
    public class GetCurrenciesWithPaginationQueryHandler : IRequestHandler<GetCurrenciesWithPaginationQuery, PaginatedList<CurrenciesDTO>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetCurrenciesWithPaginationQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<PaginatedList<CurrenciesDTO>> Handle(GetCurrenciesWithPaginationQuery request, CancellationToken cancellationToken)
        {

            var result=
             await _context.Currencies
               .OrderBy(x => x.currencyName)
               .Include(a=>a.ExCurrenciesDashboard)
               .ProjectTo<CurrenciesDTO>(_mapper.ConfigurationProvider)
               .PaginatedListAsync(request.PageNumber, request.PageSize);

        
        return result;
        }
    }
}

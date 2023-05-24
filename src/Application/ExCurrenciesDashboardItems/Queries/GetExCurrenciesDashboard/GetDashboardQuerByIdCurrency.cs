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

namespace ExCurrency.Application.ExCurrenciesDashboardItems.Queries.GetExCurrenciesDashboard;
public class GetDashboardQuerByIdCurrency : IRequest<PaginatedList<ExCurrenciesDashboardDTO>>
{
    public int PageNumber { get; init; } = 1;
    public int CurrenciesId { get; init; } 
    public int PageSize { get; init; } = 100;


    public class GetDashboardQuerByIdCurrencyHandler : IRequestHandler<GetDashboardQuerByIdCurrency, PaginatedList<ExCurrenciesDashboardDTO>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;
        public GetDashboardQuerByIdCurrencyHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            
        }
        public async Task<PaginatedList<ExCurrenciesDashboardDTO>> Handle(GetDashboardQuerByIdCurrency request, CancellationToken cancellationToken)
        {
          var result=await _context.ExCurrenciesDashboard
               .OrderBy(x => x.ApplicationUserId)
               .Where(a=>a.CurrenciesId== request.CurrenciesId)
               .ProjectTo<ExCurrenciesDashboardDTO>(_mapper.ConfigurationProvider)
               .PaginatedListAsync(request.PageNumber, request.PageSize);
            return result;


        }
    }
}

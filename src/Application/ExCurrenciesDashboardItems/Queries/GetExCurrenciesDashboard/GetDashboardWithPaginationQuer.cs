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
public class GetDashboardWithPaginationQuer:IRequest<PaginatedList<ExCurrenciesDashboardDTO>>
{
    public int PageNumber { get; init; } = 1;
    public int PageSize { get; init; } = 10;


    public class GetDashboardWithPaginationQuerHandler : IRequestHandler<GetDashboardWithPaginationQuer, PaginatedList<ExCurrenciesDashboardDTO>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;
        public GetDashboardWithPaginationQuerHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            
        }
        public async Task<PaginatedList<ExCurrenciesDashboardDTO>> Handle(GetDashboardWithPaginationQuer request, CancellationToken cancellationToken)
        {
            return await _context.ExCurrenciesDashboard
               .OrderBy(x => x.ApplicationUserId)
               .Include(a=>a.Currencies)
               .ProjectTo<ExCurrenciesDashboardDTO>(_mapper.ConfigurationProvider)
               .PaginatedListAsync(request.PageNumber, request.PageSize);
               
        }
    }
}

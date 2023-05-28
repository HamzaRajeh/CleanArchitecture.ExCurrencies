using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using ExCurrency.Application.Common.Exceptions;
using ExCurrency.Application.Common.Interfaces;
using ExCurrency.Application.ExCurrenciesDashboardItems.Commands.UpdateExCurrenciesDashboard;
using ExCurrency.Domain.Entities;
using ExCurrency.Domain.Entities.Identity;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ExCurrency.Application.ExCurrenciesDashboardItems.Commands.CreateExCurrenciesDashboard;
public class SetUpdateDashboardCommand : IRequest<int>
{
    public int? CurrenciesId { get; set; }
    public decimal BuyRate { get; set; } = 0;
    public decimal SaleRate { get; set; } = 0;
    public string? ApplicationUserId { get; set; }
}

public class SetUpdateDashboardCommandHandler : IRequestHandler<SetUpdateDashboardCommand, int>
{
    private readonly IApplicationDbContext _context;
    private readonly UserManager<Users> _Users;

    public SetUpdateDashboardCommandHandler(IApplicationDbContext context,UserManager<Users> UsersList)
    {
        _Users = UsersList;
        _context = context; 
    }

   public async Task<int> Handle(SetUpdateDashboardCommand request, CancellationToken cancellationToken)
    {
        try
        {

            #region Database 

          
            var id= _context.ExCurrenciesDashboard.Where(a =>  a.CurrenciesId == request.CurrenciesId).Select(a=>a.Id).FirstOrDefault();   
        var entity =  _context.ExCurrenciesDashboard.Find(id);
        if (entity != null)
        {
            entity.BuyRate = request.BuyRate;
            entity.SaleRate = request.SaleRate;
            await _context.SaveChangesAsync(cancellationToken);
        }
        else
        {
         var Nentity = new ExCurrenciesDashboard
        {
                CurrenciesId = request.CurrenciesId,    
                BuyRate = request.BuyRate,  
                SaleRate = request.SaleRate,    
                ApplicationUserId = request.ApplicationUserId,  
        };


            Nentity.AddDomainEvent(new ExCurrenciesDashboardCreatedEvent(Nentity));
         _context.ExCurrenciesDashboard.Add(Nentity);

       await _context.SaveChangesAsync(cancellationToken);

        }
        var entityH = new ExCurrenciesHistory
        {
            CurrencyId = request.CurrenciesId,
            BuyRate = request.BuyRate,
            SaleRate = request.SaleRate,
            UsersId = request.ApplicationUserId,
        };

        entityH.AddDomainEvent(new ExCurrenciesHistoryCreatedEvent(entityH));
        _context.ExCurrenciesHistory.Add(entityH);

        await _context.SaveChangesAsync(cancellationToken);
            #endregion

            #region send to systems

            //Requests
            List<HttpRequestMessage> Requests = new List<HttpRequestMessage>();
           
            var listUser=_Users.Users.ToList();
            foreach (Users item in listUser)
            {
                if (!string.IsNullOrEmpty(item.POSTURL))
                {
                var requestClient = new HttpRequestMessage(HttpMethod.Post, item.POSTURL);
                requestClient.Headers.Add("Authorization", string.Format("Bearer {0}","Token"));
                var contentString = string.Format("\"currenciesId\":{0},\"buyRate\":{1}, \"saleRate\":{2},  \"applicationUserId\": \"{3}\"", request.CurrenciesId, request.BuyRate, request.SaleRate, request.ApplicationUserId);
                var content = new StringContent("{"+contentString+"}", null, "application/json");
                requestClient.Content = content;
                Requests.Add(requestClient);

                }

            }
            List<dynamic> respons = new List<dynamic>();

            //client
            HttpClient client = new HttpClient();
            foreach (HttpRequestMessage item in Requests)
            {
                respons.Add(await client.SendAsync(item));
            }


            // Feadback
            //response.EnsureSuccessStatusCode();
            //Console.WriteLine(await response.Content.ReadAsStringAsync());
            #endregion

            return 1;
        }
        catch (Exception ex)
        {

            return 0;
        }

    }
}
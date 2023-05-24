using System.Xml.Serialization;
using CsvHelper.Configuration.Attributes;
using ExCurrency.Application.CurrencyItems.Commands.daleteCurrencies;
using ExCurrency.WebUI.Controllers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers.CurrenciesCTR;

public class DeleteCurrenciesController : ApiControllerBase
{
    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        await Mediator.Send(new DeleteCurrenciesCommand(id));

        return NoContent();
    }
}

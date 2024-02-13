using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RockseatAuction.API.Comunication.Request;
using RockseatAuction.API.Filters;
using RockseatAuction.API.UserCases.Offers.CreateOffer;

namespace RockseatAuction.API.Controllers;

[ServiceFilter(typeof(AuthenticationUserAttribute))]
public class OfferController : RockseatAuctionBaseController
{
    [HttpPost]
    [Route("{itemId}")]

    public IActionResult CreateOffer([FromRoute] int itemId,
                                     [FromBody] RequestCreateOfferJson request,
                                     [FromServices] CreateOfferUseCase useCase)
    {
        var id = useCase.Execute(itemId, request);

        return Created(string.Empty,id);
    }
}

using Microsoft.AspNetCore.Mvc;
using RockseatAuction.API.Entities;
using RockseatAuction.API.UserCases.Auctions.GetCurrent;

namespace RockseatAuction.API.Controllers
{

    public class AuctionController : RockseatAuctionBaseController
    {
        [HttpGet]
        [ProducesResponseType(typeof(Auction), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult GetCurrentAuction()
        {
            var useCase = new GetCurrentAuctionUseCase();

            var result = useCase.execute();
            if (result is null)
                return NoContent();

            return Ok(result);
        }

 
   
    }
}

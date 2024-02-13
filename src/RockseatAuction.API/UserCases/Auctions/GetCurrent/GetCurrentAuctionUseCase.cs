using Microsoft.EntityFrameworkCore;
using RockseatAuction.API.Entities;
using RockseatAuction.API.Repositories;

namespace RockseatAuction.API.UserCases.Auctions.GetCurrent;

public class GetCurrentAuctionUseCase
{
    public Auction? execute() 
    {
        var repository = new RockseatAuctionDbContext();

        return repository
            .Auctions
            .Include(aution => aution.Items)
            .FirstOrDefault(auction => today >= auction.Starts && today <= auction.Ends);
    }
}

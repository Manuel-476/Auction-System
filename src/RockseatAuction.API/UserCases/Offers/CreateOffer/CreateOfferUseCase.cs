using RockseatAuction.API.Comunication.Request;
using RockseatAuction.API.Entities;
using RockseatAuction.API.Repositories;
using RockseatAuction.API.Services;

namespace RockseatAuction.API.UserCases.Offers.CreateOffer;

public class CreateOfferUseCase
{
    private readonly LoggedUser _loggedUser;

    public CreateOfferUseCase(LoggedUser loggedUser)=> _loggedUser = loggedUser;

    public int Execute(int ItemId,RequestCreateOfferJson request) 
    {
        var repository = new RockseatAuctionDbContext();

        var user = _loggedUser.User();

        var offer = new Offer
        {
            CreatedOn = DateTime.Now,
            ItemId = ItemId,
            Price = request.Price,
            UserId = user.Id
        };

        repository.Offers.Add(offer);

        repository.SaveChanges();

        return offer.Id;
    }
}

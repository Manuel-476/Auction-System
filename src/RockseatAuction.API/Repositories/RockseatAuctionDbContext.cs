using Microsoft.EntityFrameworkCore;
using RockseatAuction.API.Entities;

namespace RockseatAuction.API.Repositories;

public class RockseatAuctionDbContext : DbContext
{   
    public DbSet<Auction> Auctions { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Offer> Offers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
    {
        optionsBuilder.UseSqlite(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+@"\Visual Studio 2022\projects\lilaoDBNLW.db");
    }
}

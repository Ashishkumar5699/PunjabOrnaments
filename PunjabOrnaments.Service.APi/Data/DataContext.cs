using PunjabOrnaments.Service.APi.Entities;
using PunjabOrnaments.Service.APi.Entities.Contacts;
using PunjabOrnaments.Service.APi.Entities.Purchase;
using PunjabOrnaments.Service.APi.Entities.Stock;
using Microsoft.EntityFrameworkCore;

namespace PunjabOrnaments.Service.APi.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<AppUser> Users { get; set; }
        public DbSet<Gold> GoldStock { get; set; }
        public DbSet<PurchaseRequest> PurchaseRequests { get; set; }
        public DbSet<ContactDetails> ContactDetails { get; set; }
    }
}

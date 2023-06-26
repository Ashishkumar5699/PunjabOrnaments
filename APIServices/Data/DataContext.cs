using APIServices.Entities;
using Microsoft.EntityFrameworkCore;

namespace APIServices.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<AppUser> Users { get; set; }
    }
}

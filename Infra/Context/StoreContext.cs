using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Infra.Context
{
    public class StoreContext : DbContext
    {
        public StoreContext()
        {}
        public StoreContext(DbContextOptions  options) : base(options) 
        {}
        
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
    }
}

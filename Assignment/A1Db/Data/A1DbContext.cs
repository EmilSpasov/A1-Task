using A1Db.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace A1Db.Data
{
    public class A1DbContext : DbContext
    {
        public A1DbContext()
        {
        }

        public A1DbContext(DbContextOptions options)
            : base(options)
        {
        }

        public virtual DbSet<Offer> Offers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer(Configuration.ConnectionString);
            }
        }
    }
}

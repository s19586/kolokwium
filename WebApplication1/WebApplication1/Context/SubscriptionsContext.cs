using WebApplication1.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Context
{
    public class SubscriptionsContext : DbContext
    {
        public SubscriptionsContext(DbContextOptions<SubscriptionsContext> options) : base(options) { }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Payment> Payments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sale>()
                .HasKey(s => new { s.IdClient, s.IdSubscription });
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Data.Database
{
    public class Context : IdentityDbContext
    {
        public Context(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        #region Database Tables
        public DbSet<Address> Addresses { get; set; }

        public DbSet<BuyBasket> BuyBaskets { get; set; }

        public DbSet<BuyBasketProduct> BuyBasketProducts { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderProduct> OrderProducts { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<ProductPropertis> ProductPropertys { get; set; }

        public DbSet<Seller> Sellers { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>()
        .HasOne(a => a.BuyBasket)
        .WithOne(b => b.Customer)
        .HasForeignKey<BuyBasket>(b => b.CustomerId);
        }
    }
}

using BookStoreDBImplementation.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStoreDBImplementation
{
    public class BookStoreContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-82A8HG1\SQLEXPRESS;
                Initial Catalog=BookStoreDatabase;Integrated Security=True;
                MultipleActiveResultSets=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasIndex(b => b.Title);
            modelBuilder.Entity<Author>().HasIndex(a => a.FirstName);
            modelBuilder.Entity<Author>().HasIndex(a => a.LastName);
            modelBuilder.Entity<Order>().HasIndex(o => o.PlacementDate);
        }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<BookWarehouse> BookWarehouses { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderBook> OrderBooks { get; set; }
        public virtual DbSet<Publishing> Publishings { get; set; }
        public virtual DbSet<Warehouse> Warehouses { get; set; }
    }
}

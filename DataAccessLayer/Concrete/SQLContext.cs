using EntityLayer;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{
    public class SQLContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Integrated Security=True;Initial Catalog=ObjectOrientedProgrammingDBV2;");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}

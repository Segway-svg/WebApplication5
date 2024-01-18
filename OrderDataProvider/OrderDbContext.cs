using Microsoft.EntityFrameworkCore;
using OrderModelsDb;

namespace OrderDataProvider
{
    public class OrderDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // add to appsettings.json
            //optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS01;Database=NewOrderDB;Trusted_Connection=True;TrustServerCertificate=True");
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS01;Database=NewOrdersDb;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True");
        }

        public DbSet<DbOrder> Orders { get; set; }
    }
}
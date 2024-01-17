using Microsoft.EntityFrameworkCore;
using OrderModelsDb;

namespace OrderDataProvider
{
    public class OrderDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // add to appsettings.json
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS01;Database=master;Trusted_Connection=True;");
        }

        public DbSet<DbOrder> LSO { get; set; }
    }
}
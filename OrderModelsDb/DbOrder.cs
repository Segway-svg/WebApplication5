using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OrderModelsDb
{
    public class DbOrder
    {
        public Guid Id { get; set; }
        public string senderCity { get; set; }
        public string senderAddress { get; set; }
        public string customerCity { get; set; }
        public string customerAddress { get; set; }
        public double packageWeight { get; set; }
        public DateTime deliveryDate { get; set; }

        //public ICollection<DbOrder> Orders { get; set; }

        //public DbOrder()
        //{
        //    Orders = new HashSet<DbOrder>();
        //}
    }

    public class DbOrderConfiguration : IEntityTypeConfiguration<DbOrder>
    {
        public void Configure(EntityTypeBuilder<DbOrder> builder)
        {
            builder.
                ToTable("Orders");

            builder
                .HasKey(o => o.Id);
        }
    }
}

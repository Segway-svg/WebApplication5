using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OrderDataProvider
{
    [DbContext(typeof(OrderDbContext))]
    [Migration("20240117134900_InitialCreate")]
    public class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false, type: "uniqueidentifier"),
                    senderCity = table.Column<string>(nullable: false),
                    senderAddress = table.Column<string>(nullable: false),
                    customerCity = table.Column<string>(nullable: false),
                    customerAddress = table.Column<string>(nullable: false),
                    packageWeight = table.Column<double>(nullable: false),
                    deliveryDate = table.Column<DateTime>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", o => o.Id);
                }
                );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Orders");
        }
    }
}

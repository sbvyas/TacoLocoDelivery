using Microsoft.EntityFrameworkCore.Migrations;

namespace TacoLoco.Migrations
{
    public partial class Migrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TacoLocoDelivery",
                columns: table => new
                {
                    DeliveryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    StreetAddress1 = table.Column<string>(nullable: false),
                    StreetAddress2 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: false),
                    State = table.Column<string>(nullable: false),
                    ZipCode = table.Column<long>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false),
                    DeliveryStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TacoLocoDelivery", x => x.DeliveryId);
                });

            migrationBuilder.InsertData(
                table: "TacoLocoDelivery",
                columns: new[] { "DeliveryId", "City", "DeliveryStatus", "FirstName", "LastName", "PhoneNumber", "State", "StreetAddress1", "StreetAddress2", "ZipCode" },
                values: new object[,]
                {
                    { 1, "Canton", 0, "Shivani", "Vyas", "1234567890", "Michigan", "Canton", "", 48188L },
                    { 2, "Detroit", 1, "Bob", "Arnold", "1568217890", "Michigan", "Lauree Ville Dr", "House Number 1103", 48100L },
                    { 3, "Canton", 2, "John", "Smith", "1234567890", "Michigan", "Queens Ln", "Apt Honeycomb Circle, 1212", 48188L },
                    { 4, "Los Angeles", 2, "Steve", "Jobs", "9997845896", "California", "McLumpha Dr", "House # 1001", 57814L },
                    { 5, "San Francisco", 1, "Bill", "Gates", "8833052351", "California", "Mountain View Ln", "House # 007", 415205L }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TacoLocoDelivery");
        }
    }
}

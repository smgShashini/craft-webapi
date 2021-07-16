using Microsoft.EntityFrameworkCore.Migrations;

namespace CraftWebApi.Migrations
{
    public partial class InitialProductsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemId = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    Rate = table.Column<int>(nullable: false),
                    MainImage = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    AvailableItems = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}

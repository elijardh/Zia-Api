using Microsoft.EntityFrameworkCore.Migrations;

namespace ZiaMall.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(nullable: true),
                    ProductCost = table.Column<int>(nullable: false),
                    ProductDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ProductCost", "ProductDescription", "ProductName" },
                values: new object[] { 1, 20, "Fooking Expensive", "Jaguar" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ProductCost", "ProductDescription", "ProductName" },
                values: new object[] { 2, 40, "I don't think you can afford it", "BENZ" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}

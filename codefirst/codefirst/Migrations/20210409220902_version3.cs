using Microsoft.EntityFrameworkCore.Migrations;

namespace codefirst.Migrations
{
    public partial class version3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "productid",
                table: "Employees",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Productdetails",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    owner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productdetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Productdetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "productId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_productid",
                table: "Employees",
                column: "productid");

            migrationBuilder.CreateIndex(
                name: "IX_Productdetails_ProductId",
                table: "Productdetails",
                column: "ProductId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Products_productid",
                table: "Employees",
                column: "productid",
                principalTable: "Products",
                principalColumn: "productId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Products_productid",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "Productdetails");

            migrationBuilder.DropIndex(
                name: "IX_Employees_productid",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "productid",
                table: "Employees");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIServices.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PurchaseRequests",
                columns: table => new
                {
                    PurchaseRequestId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MatelType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManufactureId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManufactureName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GrossWeight = table.Column<double>(type: "float", nullable: false),
                    LessWeight = table.Column<double>(type: "float", nullable: false),
                    NetWeight = table.Column<double>(type: "float", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Rate = table.Column<double>(type: "float", nullable: false),
                    Wastage = table.Column<double>(type: "float", nullable: false),
                    Labour = table.Column<double>(type: "float", nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsApproved = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseRequests", x => x.PurchaseRequestId);
                });

            migrationBuilder.CreateTable(
                name: "GoldStock",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GrossWeight = table.Column<double>(type: "float", nullable: false),
                    LessWeight = table.Column<double>(type: "float", nullable: false),
                    NetWeight = table.Column<double>(type: "float", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Carrot = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurchaseRequestId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoldStock", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GoldStock_PurchaseRequests_PurchaseRequestId",
                        column: x => x.PurchaseRequestId,
                        principalTable: "PurchaseRequests",
                        principalColumn: "PurchaseRequestId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_GoldStock_PurchaseRequestId",
                table: "GoldStock",
                column: "PurchaseRequestId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GoldStock");

            migrationBuilder.DropTable(
                name: "PurchaseRequests");
        }
    }
}

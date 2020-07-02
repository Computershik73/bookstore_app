using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStoreDBImplementation.Migrations
{
    public partial class UpdateDBMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Warehouses_AddressID",
                table: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_AddressID",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "AddressID",
                table: "Addresses");

            migrationBuilder.CreateIndex(
                name: "IX_Warehouses_AddressID",
                table: "Warehouses",
                column: "AddressID");

            migrationBuilder.AddForeignKey(
                name: "FK_Warehouses_Addresses_AddressID",
                table: "Warehouses",
                column: "AddressID",
                principalTable: "Addresses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Warehouses_Addresses_AddressID",
                table: "Warehouses");

            migrationBuilder.DropIndex(
                name: "IX_Warehouses_AddressID",
                table: "Warehouses");

            migrationBuilder.AddColumn<int>(
                name: "AddressID",
                table: "Addresses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_AddressID",
                table: "Addresses",
                column: "AddressID",
                unique: true,
                filter: "[AddressID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Warehouses_AddressID",
                table: "Addresses",
                column: "AddressID",
                principalTable: "Warehouses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

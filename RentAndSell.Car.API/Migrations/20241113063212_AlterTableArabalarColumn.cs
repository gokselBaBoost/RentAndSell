using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentAndSell.Car.API.Migrations
{
    /// <inheritdoc />
    public partial class AlterTableArabalarColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Update",
                table: "Arabalar",
                newName: "Updated");

            migrationBuilder.RenameColumn(
                name: "Delete",
                table: "Arabalar",
                newName: "Deleted");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Updated",
                table: "Arabalar",
                newName: "Update");

            migrationBuilder.RenameColumn(
                name: "Deleted",
                table: "Arabalar",
                newName: "Delete");
        }
    }
}

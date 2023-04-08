using Microsoft.EntityFrameworkCore.Migrations;

namespace RentACar.Data.Migrations
{
    public partial class UpdatedVehicle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsFreeOnDate",
                table: "Vehicles");

            migrationBuilder.AddColumn<bool>(
                name: "IsAccept",
                table: "Vehicles",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAccept",
                table: "Vehicles");

            migrationBuilder.AddColumn<bool>(
                name: "IsFreeOnDate",
                table: "Vehicles",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}

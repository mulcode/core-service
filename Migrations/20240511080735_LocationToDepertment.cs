using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreService.Migrations
{
    /// <inheritdoc />
    public partial class LocationToDepertment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "Depertments",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Depertments_LocationId",
                table: "Depertments",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Depertments_Locations_LocationId",
                table: "Depertments",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Depertments_Locations_LocationId",
                table: "Depertments");

            migrationBuilder.DropIndex(
                name: "IX_Depertments_LocationId",
                table: "Depertments");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Depertments");
        }
    }
}

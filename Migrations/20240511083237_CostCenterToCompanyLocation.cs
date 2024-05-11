using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreService.Migrations
{
    /// <inheritdoc />
    public partial class CostCenterToCompanyLocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "CostCenters",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "CostCenters",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CostCenters_CompanyId",
                table: "CostCenters",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_CostCenters_LocationId",
                table: "CostCenters",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_CostCenters_Companies_CompanyId",
                table: "CostCenters",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CostCenters_Locations_LocationId",
                table: "CostCenters",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CostCenters_Companies_CompanyId",
                table: "CostCenters");

            migrationBuilder.DropForeignKey(
                name: "FK_CostCenters_Locations_LocationId",
                table: "CostCenters");

            migrationBuilder.DropIndex(
                name: "IX_CostCenters_CompanyId",
                table: "CostCenters");

            migrationBuilder.DropIndex(
                name: "IX_CostCenters_LocationId",
                table: "CostCenters");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "CostCenters");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "CostCenters");
        }
    }
}

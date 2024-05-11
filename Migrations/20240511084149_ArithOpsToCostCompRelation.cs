using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreService.Migrations
{
    /// <inheritdoc />
    public partial class ArithOpsToCostCompRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArithId",
                table: "CostToComs",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ArithmaticOperationsId",
                table: "CostToComs",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CostToComs_ArithmaticOperationsId",
                table: "CostToComs",
                column: "ArithmaticOperationsId");

            migrationBuilder.AddForeignKey(
                name: "FK_CostToComs_ArithmaticOperations_ArithmaticOperationsId",
                table: "CostToComs",
                column: "ArithmaticOperationsId",
                principalTable: "ArithmaticOperations",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CostToComs_ArithmaticOperations_ArithmaticOperationsId",
                table: "CostToComs");

            migrationBuilder.DropIndex(
                name: "IX_CostToComs_ArithmaticOperationsId",
                table: "CostToComs");

            migrationBuilder.DropColumn(
                name: "ArithId",
                table: "CostToComs");

            migrationBuilder.DropColumn(
                name: "ArithmaticOperationsId",
                table: "CostToComs");
        }
    }
}

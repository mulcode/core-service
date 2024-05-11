using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreService.Migrations
{
    /// <inheritdoc />
    public partial class DeptToDevisionRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepertmentId",
                table: "Devisions",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Devisions_DepertmentId",
                table: "Devisions",
                column: "DepertmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Devisions_Depertments_DepertmentId",
                table: "Devisions",
                column: "DepertmentId",
                principalTable: "Depertments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devisions_Depertments_DepertmentId",
                table: "Devisions");

            migrationBuilder.DropIndex(
                name: "IX_Devisions_DepertmentId",
                table: "Devisions");

            migrationBuilder.DropColumn(
                name: "DepertmentId",
                table: "Devisions");
        }
    }
}

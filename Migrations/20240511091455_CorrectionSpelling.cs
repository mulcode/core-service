using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CoreService.Migrations
{
    /// <inheritdoc />
    public partial class CorrectionSpelling : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CostToComs_ArithmaticOperations_ArithmaticOperationsId",
                table: "CostToComs");

            migrationBuilder.DropForeignKey(
                name: "FK_Devisions_Depertments_DepertmentId",
                table: "Devisions");

            migrationBuilder.DropTable(
                name: "Depertments");

            migrationBuilder.DropColumn(
                name: "ArithId",
                table: "CostToComs");

            migrationBuilder.RenameColumn(
                name: "DepertmentId",
                table: "Devisions",
                newName: "DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Devisions_DepertmentId",
                table: "Devisions",
                newName: "IX_Devisions_DepartmentId");

            migrationBuilder.AlterColumn<int>(
                name: "ArithmaticOperationsId",
                table: "CostToComs",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Code = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    SortOrder = table.Column<short>(type: "smallint", nullable: false),
                    LocationId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Departments_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Departments_LocationId",
                table: "Departments",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_CostToComs_ArithmaticOperations_ArithmaticOperationsId",
                table: "CostToComs",
                column: "ArithmaticOperationsId",
                principalTable: "ArithmaticOperations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Devisions_Departments_DepartmentId",
                table: "Devisions",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CostToComs_ArithmaticOperations_ArithmaticOperationsId",
                table: "CostToComs");

            migrationBuilder.DropForeignKey(
                name: "FK_Devisions_Departments_DepartmentId",
                table: "Devisions");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Devisions",
                newName: "DepertmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Devisions_DepartmentId",
                table: "Devisions",
                newName: "IX_Devisions_DepertmentId");

            migrationBuilder.AlterColumn<int>(
                name: "ArithmaticOperationsId",
                table: "CostToComs",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "ArithId",
                table: "CostToComs",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Depertments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    LocationId = table.Column<int>(type: "integer", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    SortOrder = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Depertments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Depertments_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Depertments_LocationId",
                table: "Depertments",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_CostToComs_ArithmaticOperations_ArithmaticOperationsId",
                table: "CostToComs",
                column: "ArithmaticOperationsId",
                principalTable: "ArithmaticOperations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Devisions_Depertments_DepertmentId",
                table: "Devisions",
                column: "DepertmentId",
                principalTable: "Depertments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

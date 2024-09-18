using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BachelorTherasoftDotnetInfrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Second3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Document_DocumentCategory_DocumentCategoryId",
                table: "Document");

            migrationBuilder.UpdateData(
                table: "Document",
                keyColumn: "DocumentCategoryId",
                keyValue: null,
                column: "DocumentCategoryId",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "DocumentCategoryId",
                table: "Document",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_Document_DocumentCategory_DocumentCategoryId",
                table: "Document",
                column: "DocumentCategoryId",
                principalTable: "DocumentCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Document_DocumentCategory_DocumentCategoryId",
                table: "Document");

            migrationBuilder.AlterColumn<string>(
                name: "DocumentCategoryId",
                table: "Document",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_Document_DocumentCategory_DocumentCategoryId",
                table: "Document",
                column: "DocumentCategoryId",
                principalTable: "DocumentCategory",
                principalColumn: "Id");
        }
    }
}

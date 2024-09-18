using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BachelorTherasoftDotnetInfrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Second2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DocumentDocumentCategory");

            migrationBuilder.AddColumn<string>(
                name: "DocumentCategoryId",
                table: "Document",
                type: "varchar(255)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Document_DocumentCategoryId",
                table: "Document",
                column: "DocumentCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Document_DocumentCategory_DocumentCategoryId",
                table: "Document",
                column: "DocumentCategoryId",
                principalTable: "DocumentCategory",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Document_DocumentCategory_DocumentCategoryId",
                table: "Document");

            migrationBuilder.DropIndex(
                name: "IX_Document_DocumentCategoryId",
                table: "Document");

            migrationBuilder.DropColumn(
                name: "DocumentCategoryId",
                table: "Document");

            migrationBuilder.CreateTable(
                name: "DocumentDocumentCategory",
                columns: table => new
                {
                    DocumentCategoriesId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DocumentsId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentDocumentCategory", x => new { x.DocumentCategoriesId, x.DocumentsId });
                    table.ForeignKey(
                        name: "FK_DocumentDocumentCategory_DocumentCategory_DocumentCategories~",
                        column: x => x.DocumentCategoriesId,
                        principalTable: "DocumentCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DocumentDocumentCategory_Document_DocumentsId",
                        column: x => x.DocumentsId,
                        principalTable: "Document",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentDocumentCategory_DocumentsId",
                table: "DocumentDocumentCategory",
                column: "DocumentsId");
        }
    }
}

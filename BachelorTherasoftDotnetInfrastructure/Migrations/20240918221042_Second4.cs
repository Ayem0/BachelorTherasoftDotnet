using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BachelorTherasoftDotnetInfrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Second4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ParticipantParticipantCategory");

            migrationBuilder.AddColumn<string>(
                name: "ParticipantCategoryId",
                table: "Participant",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Participant_ParticipantCategoryId",
                table: "Participant",
                column: "ParticipantCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Participant_ParticipantCategory_ParticipantCategoryId",
                table: "Participant",
                column: "ParticipantCategoryId",
                principalTable: "ParticipantCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Participant_ParticipantCategory_ParticipantCategoryId",
                table: "Participant");

            migrationBuilder.DropIndex(
                name: "IX_Participant_ParticipantCategoryId",
                table: "Participant");

            migrationBuilder.DropColumn(
                name: "ParticipantCategoryId",
                table: "Participant");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "LastName",
                keyValue: null,
                column: "LastName",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "FirstName",
                keyValue: null,
                column: "FirstName",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ParticipantParticipantCategory",
                columns: table => new
                {
                    ParticipantCategoriesId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ParticipantsId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParticipantParticipantCategory", x => new { x.ParticipantCategoriesId, x.ParticipantsId });
                    table.ForeignKey(
                        name: "FK_ParticipantParticipantCategory_ParticipantCategory_Participa~",
                        column: x => x.ParticipantCategoriesId,
                        principalTable: "ParticipantCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ParticipantParticipantCategory_Participant_ParticipantsId",
                        column: x => x.ParticipantsId,
                        principalTable: "Participant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_ParticipantParticipantCategory_ParticipantsId",
                table: "ParticipantParticipantCategory",
                column: "ParticipantsId");
        }
    }
}

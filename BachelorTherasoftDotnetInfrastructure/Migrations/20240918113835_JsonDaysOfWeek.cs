using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BachelorTherasoftDotnetInfrastructure.Migrations
{
    /// <inheritdoc />
    public partial class JsonDaysOfWeek : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "ParticipantCategory",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "EventCategory",
                keyColumn: "Icon",
                keyValue: null,
                column: "Icon",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Icon",
                table: "EventCategory",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "DocumentCategory",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Icon",
                table: "ParticipantCategory");

            migrationBuilder.DropColumn(
                name: "Icon",
                table: "DocumentCategory");

            migrationBuilder.AlterColumn<string>(
                name: "Icon",
                table: "EventCategory",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}

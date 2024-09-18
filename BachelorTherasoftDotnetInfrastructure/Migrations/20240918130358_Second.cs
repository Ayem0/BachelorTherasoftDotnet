using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BachelorTherasoftDotnetInfrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Event_Room_RoomId",
                table: "Event");

            migrationBuilder.DropForeignKey(
                name: "FK_Event_Tag_TagId",
                table: "Event");

            migrationBuilder.DropIndex(
                name: "IX_Event_TagId",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "TagId",
                table: "Event");

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "RoomId",
                keyValue: null,
                column: "RoomId",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "RoomId",
                table: "Event",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EventTag",
                columns: table => new
                {
                    EventsId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TagsId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventTag", x => new { x.EventsId, x.TagsId });
                    table.ForeignKey(
                        name: "FK_EventTag_Event_EventsId",
                        column: x => x.EventsId,
                        principalTable: "Event",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventTag_Tag_TagsId",
                        column: x => x.TagsId,
                        principalTable: "Tag",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_EventTag_TagsId",
                table: "EventTag",
                column: "TagsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Event_Room_RoomId",
                table: "Event",
                column: "RoomId",
                principalTable: "Room",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Event_Room_RoomId",
                table: "Event");

            migrationBuilder.DropTable(
                name: "EventTag");

            migrationBuilder.AlterColumn<string>(
                name: "RoomId",
                table: "Event",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "TagId",
                table: "Event",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Event_TagId",
                table: "Event",
                column: "TagId");

            migrationBuilder.AddForeignKey(
                name: "FK_Event_Room_RoomId",
                table: "Event",
                column: "RoomId",
                principalTable: "Room",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Event_Tag_TagId",
                table: "Event",
                column: "TagId",
                principalTable: "Tag",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

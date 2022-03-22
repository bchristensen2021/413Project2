using Microsoft.EntityFrameworkCore.Migrations;

namespace _413Project2.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TimeSlots",
                columns: table => new
                {
                    TimeSlotId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TimeSlotAvailable = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeSlots", x => x.TimeSlotId);
                });

            migrationBuilder.CreateTable(
                name: "AppointmentInfo",
                columns: table => new
                {
                    AppId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: false),
                    GroupSize = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    TimeSlotId = table.Column<int>(nullable: false),
                    TimeSlotsTimeSlotId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentInfo", x => x.AppId);
                    table.ForeignKey(
                        name: "FK_AppointmentInfo_TimeSlots_TimeSlotsTimeSlotId",
                        column: x => x.TimeSlotsTimeSlotId,
                        principalTable: "TimeSlots",
                        principalColumn: "TimeSlotId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 1, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 66, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 65, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 64, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 63, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 62, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 61, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 60, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 59, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 58, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 57, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 56, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 55, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 54, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 53, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 52, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 51, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 50, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 49, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 48, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 67, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 47, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 68, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 70, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 89, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 88, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 87, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 86, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 85, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 84, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 83, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 82, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 81, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 80, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 79, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 78, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 77, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 76, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 75, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 74, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 73, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 72, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 71, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 69, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 90, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 46, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 44, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 20, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 19, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 18, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 17, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 16, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 15, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 14, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 13, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 12, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 11, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 10, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 9, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 8, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 7, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 6, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 5, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 4, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 3, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 2, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 21, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 45, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 22, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 24, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 43, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 42, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 41, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 40, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 39, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 38, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 37, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 36, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 35, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 34, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 33, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 32, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 31, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 30, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 29, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 28, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 27, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 26, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 25, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 23, true });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotAvailable" },
                values: new object[] { 91, true });

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentInfo_TimeSlotsTimeSlotId",
                table: "AppointmentInfo",
                column: "TimeSlotsTimeSlotId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppointmentInfo");

            migrationBuilder.DropTable(
                name: "TimeSlots");
        }
    }
}

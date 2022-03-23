using Microsoft.EntityFrameworkCore.Migrations;

namespace _413Project2.Migrations
{
    public partial class NameUpdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "TimeSlotId",
                keyValue: 2,
                column: "TimeSlotName",
                value: "Monday 9am");

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "TimeSlotId",
                keyValue: 3,
                column: "TimeSlotName",
                value: "Monday 10am");

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "TimeSlotId",
                keyValue: 4,
                column: "TimeSlotName",
                value: "Monday 11am");

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "TimeSlotId",
                keyValue: 5,
                column: "TimeSlotName",
                value: "Monday 12pm");

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "TimeSlotId",
                keyValue: 6,
                column: "TimeSlotName",
                value: "Monday 1pm");

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "TimeSlotId",
                keyValue: 7,
                column: "TimeSlotName",
                value: "Monday 2pm");

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "TimeSlotId",
                keyValue: 8,
                column: "TimeSlotName",
                value: "Monday 3pm");

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "TimeSlotId",
                keyValue: 9,
                column: "TimeSlotName",
                value: "Monday 4pm");

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "TimeSlotId",
                keyValue: 10,
                column: "TimeSlotName",
                value: "Monday 5pm");

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "TimeSlotId",
                keyValue: 11,
                column: "TimeSlotName",
                value: "Monday 6pm");

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "TimeSlotId",
                keyValue: 12,
                column: "TimeSlotName",
                value: "Monday 7pm");

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "TimeSlotId",
                keyValue: 13,
                column: "TimeSlotName",
                value: "Monday 8pm");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "TimeSlotId",
                keyValue: 2,
                column: "TimeSlotName",
                value: null);

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "TimeSlotId",
                keyValue: 3,
                column: "TimeSlotName",
                value: null);

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "TimeSlotId",
                keyValue: 4,
                column: "TimeSlotName",
                value: null);

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "TimeSlotId",
                keyValue: 5,
                column: "TimeSlotName",
                value: null);

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "TimeSlotId",
                keyValue: 6,
                column: "TimeSlotName",
                value: null);

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "TimeSlotId",
                keyValue: 7,
                column: "TimeSlotName",
                value: null);

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "TimeSlotId",
                keyValue: 8,
                column: "TimeSlotName",
                value: null);

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "TimeSlotId",
                keyValue: 9,
                column: "TimeSlotName",
                value: null);

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "TimeSlotId",
                keyValue: 10,
                column: "TimeSlotName",
                value: null);

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "TimeSlotId",
                keyValue: 11,
                column: "TimeSlotName",
                value: null);

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "TimeSlotId",
                keyValue: 12,
                column: "TimeSlotName",
                value: null);

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "TimeSlotId",
                keyValue: 13,
                column: "TimeSlotName",
                value: null);
        }
    }
}

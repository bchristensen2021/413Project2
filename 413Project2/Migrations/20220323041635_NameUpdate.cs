using Microsoft.EntityFrameworkCore.Migrations;

namespace _413Project2.Migrations
{
    public partial class NameUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TimeSlotName",
                table: "TimeSlots",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "TimeSlotId",
                keyValue: 1,
                column: "TimeSlotName",
                value: "Monday 8am");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimeSlotName",
                table: "TimeSlots");
        }
    }
}

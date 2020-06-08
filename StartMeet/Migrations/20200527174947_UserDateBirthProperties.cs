using Microsoft.EntityFrameworkCore.Migrations;

namespace StartMeet.Migrations
{
    public partial class UserDateBirthProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Day",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Month",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Year",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Day",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Month",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "AspNetUsers");
        }
    }
}

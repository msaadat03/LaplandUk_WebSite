using Microsoft.EntityFrameworkCore.Migrations;

namespace Back_end.Migrations
{
    public partial class AddColumnTitle2ToTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "HomeInvitations");

            migrationBuilder.AddColumn<string>(
                name: "Title1",
                table: "HomeInvitations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title2",
                table: "HomeInvitations",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title1",
                table: "HomeInvitations");

            migrationBuilder.DropColumn(
                name: "Title2",
                table: "HomeInvitations");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "HomeInvitations",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

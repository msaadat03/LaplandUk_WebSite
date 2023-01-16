using Microsoft.EntityFrameworkCore.Migrations;

namespace Back_end.Migrations
{
    public partial class AddColumnIsDeletedToBaseEntityTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Home_worlds");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Logos",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "HomeWorlds",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    UpperTitle1 = table.Column<string>(nullable: true),
                    UpperTitle2 = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Desc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeWorlds", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HomeWorlds");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Logos");

            migrationBuilder.CreateTable(
                name: "Home_worlds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpperTitle1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpperTitle2 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Home_worlds", x => x.Id);
                });
        }
    }
}

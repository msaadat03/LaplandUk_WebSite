using Microsoft.EntityFrameworkCore.Migrations;

namespace Back_end.Migrations
{
    public partial class CreateRedBookAppTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_redBookPages",
                table: "redBookPages");

            migrationBuilder.RenameTable(
                name: "redBookPages",
                newName: "RedBookPages");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RedBookPages",
                table: "RedBookPages",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "RedBookApps",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Desc = table.Column<string>(nullable: true),
                    Images = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RedBookApps", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RedBookApps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RedBookPages",
                table: "RedBookPages");

            migrationBuilder.RenameTable(
                name: "RedBookPages",
                newName: "redBookPages");

            migrationBuilder.AddPrimaryKey(
                name: "PK_redBookPages",
                table: "redBookPages",
                column: "Id");
        }
    }
}

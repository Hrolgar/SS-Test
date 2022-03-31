using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class Newmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_FirstSchema",
                table: "FirstSchema");

            migrationBuilder.RenameTable(
                name: "FirstSchema",
                newName: "MyFirstSchema");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyFirstSchema",
                table: "MyFirstSchema",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MyFirstSchema",
                table: "MyFirstSchema");

            migrationBuilder.RenameTable(
                name: "MyFirstSchema",
                newName: "FirstSchema");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FirstSchema",
                table: "FirstSchema",
                column: "Id");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazingLego.Migrations
{
    public partial class initial_v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Pieces",
                table: "LegoSet",
                newName: "YearReleased");

            migrationBuilder.RenameColumn(
                name: "Acquired",
                table: "LegoSet",
                newName: "YearAcquired");

            migrationBuilder.AlterColumn<string>(
                name: "IsOnDisplay",
                table: "LegoSet",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TotalParts",
                table: "LegoSet",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalParts",
                table: "LegoSet");

            migrationBuilder.RenameColumn(
                name: "YearReleased",
                table: "LegoSet",
                newName: "Pieces");

            migrationBuilder.RenameColumn(
                name: "YearAcquired",
                table: "LegoSet",
                newName: "Acquired");

            migrationBuilder.AlterColumn<bool>(
                name: "IsOnDisplay",
                table: "LegoSet",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFSQLite.Migrations
{
    /// <inheritdoc />
    public partial class nullablePerson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PLZ",
                table: "Staedte",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "Alter",
                table: "Personen",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PLZ",
                table: "Staedte");

            migrationBuilder.AlterColumn<int>(
                name: "Alter",
                table: "Personen",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);
        }
    }
}

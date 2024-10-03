using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace io.Migrations
{
    /// <inheritdoc />
    public partial class SecondCommit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Position",
                table: "Employees");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "Employees",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}

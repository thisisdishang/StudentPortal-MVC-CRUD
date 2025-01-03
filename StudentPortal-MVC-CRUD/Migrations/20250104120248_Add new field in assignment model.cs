using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentPortal_MVC_CRUD.Migrations
{
    /// <inheritdoc />
    public partial class Addnewfieldinassignmentmodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Subject",
                table: "Assignment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Subject",
                table: "Assignment");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentPortal_MVC_CRUD.Migrations
{
    /// <inheritdoc />
    public partial class UpdateColumnMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Subcribed",
                table: "Students",
                newName: "Subscribed");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Subscribed",
                table: "Students",
                newName: "Subcribed");
        }
    }
}

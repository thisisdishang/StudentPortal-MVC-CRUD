using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentPortal_MVC_CRUD.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Subsribed",
                table: "Students",
                newName: "Subcribed");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Subcribed",
                table: "Students",
                newName: "Subsribed");
        }
    }
}

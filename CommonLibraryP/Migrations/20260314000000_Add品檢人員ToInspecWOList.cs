using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CommonLibraryP.Migrations
{
    /// <inheritdoc />
    [Microsoft.EntityFrameworkCore.Migrations.Migration("20260314000000_Add品檢人員ToInspecWOList")]
    public partial class Add品檢人員ToInspecWOList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "品檢人員",
                table: "InspecWOLists",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "品檢人員",
                table: "InspecWOLists");
        }
    }
}

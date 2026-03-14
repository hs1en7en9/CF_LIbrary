using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CommonLibraryP.Migrations
{
    /// <inheritdoc />
    [Microsoft.EntityFrameworkCore.Migrations.Migration("20260314100000_Add完成時間ToInspecWOList")]
    public partial class Add完成時間ToInspecWOList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "完成時間",
                table: "InspecWOLists",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "完成時間",
                table: "InspecWOLists");
        }
    }
}

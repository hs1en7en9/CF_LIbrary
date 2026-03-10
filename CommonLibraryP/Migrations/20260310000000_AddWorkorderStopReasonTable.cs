using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CommonLibraryP.Migrations
{
    /// <inheritdoc />
    public partial class AddWorkorderStopReasonTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WorkorderStopReasons",
                columns: table => new
                {
                    停工原因代碼 = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    停工原因名稱 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    停工分類 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    備註 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkorderStopReasons", x => x.停工原因代碼);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkorderStopReasons");
        }
    }
}

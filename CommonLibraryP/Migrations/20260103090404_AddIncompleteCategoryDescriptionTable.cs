using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CommonLibraryP.Migrations
{
    /// <inheritdoc />
    public partial class AddIncompleteCategoryDescriptionTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // 若欄位已存在（例如曾手動或部分套用）則略過，避免「資料行名稱指定了一次以上」錯誤
            migrationBuilder.Sql(@"
                IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('InspectionRecords') AND name = N'未完成說明')
                    ALTER TABLE [InspectionRecords] ADD [未完成說明] nvarchar(max) NULL;
            ");
            migrationBuilder.Sql(@"
                IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('InspectionRecords') AND name = N'未完成類別')
                    ALTER TABLE [InspectionRecords] ADD [未完成類別] nvarchar(max) NULL;
            ");
            migrationBuilder.Sql(@"
                IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('InspectionRecords') AND name = N'維修完成日')
                    ALTER TABLE [InspectionRecords] ADD [維修完成日] datetime2 NULL;
            ");

            // 若資料表已存在則略過，避免「資料庫中已經有一個名為 'IncompleteCategoryDescriptions' 的物件」錯誤
            migrationBuilder.Sql(@"
                IF NOT EXISTS (SELECT 1 FROM sys.tables WHERE object_id = OBJECT_ID('IncompleteCategoryDescriptions'))
                BEGIN
                    CREATE TABLE [IncompleteCategoryDescriptions] (
                        [Id] int NOT NULL IDENTITY(1,1),
                        [未完成類別] nvarchar(100) NOT NULL,
                        [未完成說明] nvarchar(200) NOT NULL,
                        [排序順序] int NOT NULL,
                        CONSTRAINT [PK_IncompleteCategoryDescriptions] PRIMARY KEY ([Id])
                    );
                END
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IncompleteCategoryDescriptions");

            migrationBuilder.DropColumn(
                name: "未完成說明",
                table: "InspectionRecords");

            migrationBuilder.DropColumn(
                name: "未完成類別",
                table: "InspectionRecords");

            migrationBuilder.DropColumn(
                name: "維修完成日",
                table: "InspectionRecords");
        }
    }
}

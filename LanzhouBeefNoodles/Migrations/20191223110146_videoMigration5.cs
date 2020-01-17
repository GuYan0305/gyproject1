using Microsoft.EntityFrameworkCore.Migrations;

namespace LanzhouBeefNoodles.Migrations
{
    public partial class videoMigration5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Duration",
                table: "LearningVideo",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Duration",
                table: "LearningVideo",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}

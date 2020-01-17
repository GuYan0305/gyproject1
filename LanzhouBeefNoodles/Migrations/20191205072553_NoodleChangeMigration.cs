using Microsoft.EntityFrameworkCore.Migrations;

namespace LanzhouBeefNoodles.Migrations
{
    public partial class NoodleChangeMigration : Migration
    {
        //Noodles新加了一列
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsInStock",
                table: "Noodles",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsInStock",
                table: "Noodles");
        }
    }
}

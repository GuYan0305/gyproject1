using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LanzhouBeefNoodles.Migrations
{
    public partial class videoMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LearningVideo",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CourseID = table.Column<string>(maxLength: 200, nullable: true),
                    Teacher = table.Column<string>(maxLength: 100, nullable: true),
                    Duration = table.Column<int>(nullable: true),
                    UpdateTime = table.Column<string>(maxLength: 100, nullable: true),
                    Url = table.Column<string>(maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LearningVideo", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    FirstTime = table.Column<string>(maxLength: 100, nullable: false),
                    CourseID = table.Column<string>(maxLength: 200, nullable: false),
                    Author = table.Column<string>(maxLength: 200, nullable: true),
                    Content = table.Column<string>(maxLength: 500, nullable: false),
                    Good = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.FirstTime);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LearningVideo");

            migrationBuilder.DropTable(
                name: "Notes");
        }
    }
}

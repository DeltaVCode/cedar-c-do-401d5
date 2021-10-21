using Microsoft.EntityFrameworkCore.Migrations;

namespace Demo12.Migrations
{
    public partial class AddCoursesTableWithSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseCode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseCode", "Price" },
                values: new object[] { 1002, "dotnet-401d5", 0m });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseCode", "Price" },
                values: new object[] { 1005, "201d10", 12m });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseCode", "Price" },
                values: new object[] { 1009, "301d10", 123.45m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}

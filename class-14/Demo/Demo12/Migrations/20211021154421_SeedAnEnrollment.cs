using Microsoft.EntityFrameworkCore.Migrations;

namespace Demo12.Migrations
{
    public partial class SeedAnEnrollment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 42, 904 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 42, 904 });
        }
    }
}

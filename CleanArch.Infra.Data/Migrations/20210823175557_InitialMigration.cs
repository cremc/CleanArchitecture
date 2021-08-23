using Microsoft.EntityFrameworkCore.Migrations;

namespace CleanArch.Infra.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InstitutionID = table.Column<int>(type: "int", nullable: false),
                    CASL1SubinstitutionID = table.Column<int>(type: "int", nullable: false),
                    CASL2SubinstitutionID = table.Column<int>(type: "int", nullable: false),
                    CASL3SubinstitutionID = table.Column<int>(type: "int", nullable: false),
                    CASL4SubinstitutionID = table.Column<int>(type: "int", nullable: false),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseStartSession = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseDurationDays = table.Column<int>(type: "int", nullable: false),
                    CourseDurationWeeks = table.Column<int>(type: "int", nullable: false),
                    CourseDurationMonths = table.Column<int>(type: "int", nullable: false),
                    CourseDurationAcademicSessions = table.Column<int>(type: "int", nullable: false),
                    CourseDescriptionForCareer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseDescriptionForRigour = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TargetStudentTypeLookupID = table.Column<int>(type: "int", nullable: false),
                    AttendanceTypeLookupID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}

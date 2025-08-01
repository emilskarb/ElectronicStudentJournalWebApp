using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElectronicStudentJournal.Migrations
{
    /// <inheritdoc />
    public partial class StudGrades_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GradeReceiving",
                table: "Grades",
                newName: "GradeReceivingDate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GradeReceivingDate",
                table: "Grades",
                newName: "GradeReceiving");
        }
    }
}

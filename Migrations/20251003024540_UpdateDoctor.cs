using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pulse.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDoctor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Doctors_FullName_Specialization",
                table: "Doctors",
                columns: new[] { "FullName", "Specialization" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Doctors_FullName_Specialization",
                table: "Doctors");
        }
    }
}

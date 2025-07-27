using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TickTacker.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DailyAttendances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    StartTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    EndTime = table.Column<TimeOnly>(type: "time", nullable: true),
                    EmploymentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyAttendances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DailyAttendances_Employments_EmploymentId",
                        column: x => x.EmploymentId,
                        principalTable: "Employments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Pesel = table.Column<string>(type: "char(11)", maxLength: 11, nullable: false),
                    BirthDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Address_Country = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Address_City = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Address_Street = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Address_HouseNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Address_ApartmentNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Address_PostalCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Address_PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmergencyContact_FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EmergencyContact_LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EmergencyContact_PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    EmploymentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Employments_EmploymentId",
                        column: x => x.EmploymentId,
                        principalTable: "Employments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PaidVacations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VacationStartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    VacationEndDate = table.Column<DateOnly>(type: "date", nullable: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    EmploymentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaidVacations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaidVacations_Employments_EmploymentId",
                        column: x => x.EmploymentId,
                        principalTable: "Employments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DailyAttendances_EmploymentId",
                table: "DailyAttendances",
                column: "EmploymentId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmploymentId",
                table: "Employees",
                column: "EmploymentId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Pesel",
                table: "Employees",
                column: "Pesel",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PaidVacations_EmploymentId",
                table: "PaidVacations",
                column: "EmploymentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DailyAttendances");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "PaidVacations");

            migrationBuilder.DropTable(
                name: "Employments");
        }
    }
}

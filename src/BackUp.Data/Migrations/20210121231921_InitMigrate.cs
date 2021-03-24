using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BackUp.Data.Migrations
{
    public partial class InitMigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    JobName = table.Column<string>(type: "TEXT", nullable: true),
                    SourcePath = table.Column<string>(type: "TEXT", nullable: true),
                    DestinationPath = table.Column<string>(type: "TEXT", nullable: true),
                    BackUpType = table.Column<int>(type: "INTEGER", nullable: false),
                    DayMonth = table.Column<byte>(type: "INTEGER", nullable: false),
                    TimeToExecute = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ActivityJobs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    JobId = table.Column<int>(type: "INTEGER", nullable: true),
                    StartedExecutionDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FinishedExecutionDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    StatusType = table.Column<int>(type: "INTEGER", nullable: false),
                    Message = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityJobs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActivityJobs_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActivityJobs_JobId",
                table: "ActivityJobs",
                column: "JobId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityJobs");

            migrationBuilder.DropTable(
                name: "Jobs");
        }
    }
}

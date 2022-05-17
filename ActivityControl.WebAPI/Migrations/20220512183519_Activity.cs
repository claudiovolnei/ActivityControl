using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ActivityControl.WebAPI.Migrations
{
    public partial class Activity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Atividades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: false),
                    Observations = table.Column<string>(type: "varchar(500)", nullable: false),
                    Status = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atividades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HorasUtilizadas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Start = table.Column<DateTime>(type: "varchar(200)", nullable: false),
                    End = table.Column<DateTime>(type: "varchar(500)", nullable: false),
                    ActivityId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HorasUtilizadas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HorasUtilizadas_Atividades_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Atividades",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_HorasUtilizadas_ActivityId",
                table: "HorasUtilizadas",
                column: "ActivityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HorasUtilizadas");

            migrationBuilder.DropTable(
                name: "Atividades");
        }
    }
}

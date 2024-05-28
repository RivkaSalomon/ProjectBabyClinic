using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Solid.Data.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "lbaby",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lbaby", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ln",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    CountHours = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ln", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "li",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BabyIdId = table.Column<int>(type: "int", nullable: false),
                    NurseIdId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_li", x => x.Id);
                    table.ForeignKey(
                        name: "FK_li_lbaby_BabyIdId",
                        column: x => x.BabyIdId,
                        principalTable: "lbaby",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_li_ln_NurseIdId",
                        column: x => x.NurseIdId,
                        principalTable: "ln",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_li_BabyIdId",
                table: "li",
                column: "BabyIdId");

            migrationBuilder.CreateIndex(
                name: "IX_li_NurseIdId",
                table: "li",
                column: "NurseIdId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "li");

            migrationBuilder.DropTable(
                name: "lbaby");

            migrationBuilder.DropTable(
                name: "ln");
        }
    }
}

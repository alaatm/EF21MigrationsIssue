using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EF21MigrationsIssue.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bonuses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    MultipliesPoints = table.Column<bool>(nullable: false),
                    MultiplyFactor = table.Column<int>(nullable: true),
                    ConquerorsPoints = table.Column<bool>(nullable: false),
                    ConquerorAmount = table.Column<int>(nullable: true),
                    RequireSuccess = table.Column<bool>(nullable: false),
                    Price = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bonuses", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Bonuses",
                columns: new[] { "Id", "ConquerorAmount", "ConquerorsPoints", "MultipliesPoints", "MultiplyFactor", "Name", "Price", "RequireSuccess" },
                values: new object[,]
                {
                    { 1, null, false, false, null, "J", 0.2, false },
                    { 2, null, false, false, null, "S", 0.5, false },
                    { 3, null, false, true, 2, "D", 0.5, false },
                    { 4, 1, true, false, null, "I", 0.5, true },
                    { 5, 1, true, false, null, "F", 0.5, true },
                    { 6, null, false, false, null, "G", 0.5, false },
                    { 7, 2, true, false, null, "J", null, false },
                    { 8, null, false, false, null, "Y", 0.5, false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bonuses");
        }
    }
}

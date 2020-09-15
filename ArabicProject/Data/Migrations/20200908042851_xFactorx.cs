using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArabicProject.Data.Migrations
{
    public partial class xFactorx : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdEntree",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeOfAd = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    BodyComments = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    DateWritten = table.Column<DateTime>(nullable: false),
                    ZeroActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdEntree", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeOfAd",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    ZeroActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeOfAd", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdEntree");

            migrationBuilder.DropTable(
                name: "TypeOfAd");
        }
    }
}

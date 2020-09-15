using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArabicProject.Data.Migrations
{
    public partial class sectionAndBlog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blog",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    BodyText = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    SectionId = table.Column<int>(nullable: false),
                    DateWriten = table.Column<DateTime>(nullable: false),
                    ZeroActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blog", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blog");
        }
    }
}

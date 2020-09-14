using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HRManager.Migrations
{
    public partial class Add1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SickType",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    SickName = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SickType", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SickType");
        }
    }
}

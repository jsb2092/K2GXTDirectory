using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepeaterQTH.Migrations
{
    public partial class callsign : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Callsign",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastAccess",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Callsign",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastAccess",
                table: "AspNetUsers");
        }
    }
}

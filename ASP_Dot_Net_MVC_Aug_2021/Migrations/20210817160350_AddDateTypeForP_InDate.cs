using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP_Dot_Net_MVC_Aug_2021.Migrations
{
    public partial class AddDateTypeForP_InDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "P_InDate",
                table: "Products",
                type: "Date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "P_InDate",
                table: "Products",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Date");
        }
    }
}
